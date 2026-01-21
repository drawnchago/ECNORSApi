using ECNORSAppData.Data;
using ECNORSAppData.Data.Config;
using ECNORSAppData.Data.DTO;
using ECNORSAppData.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static System.Collections.Specialized.BitVector32;
using static System.Net.WebRequestMethods;

namespace ECNORSAppData.Services
{
    public interface ICloseLoadService
    {
        Task<List<DispensaryDto>> GetDispensariosAsync(string station, CancellationToken ct);
        Task<string> GetDbInfoAsync(string station,CancellationToken ct = default);
        Task<IReadOnlyList<TransactionDto>> GetTransactionsTopAsync(string station, int dispensaryId, CancellationToken ct = default);
        Task<IReadOnlyList<BinnacleDto>> GetBinnacleTopAsync(string station, int dispensaryId, CancellationToken ct = default);
        Task<TransactionDto?> GetTransactionBySequenceAsync(string station, long secuencia, CancellationToken ct = default);
        Task CloseManualAsync(string station, int secuenciaBuscar, decimal volumenGross, decimal volumenNetoCt, decimal temperatura, CancellationToken ct = default);
        Task<decimal> GetNetVolAutoAsync(string station,int intDispensario,int intProducto,decimal temperatura,decimal volumenGross,CancellationToken ct = default);
    }

    public sealed class CloseLoadService : ICloseLoadService
    {
        private readonly IConnectionSelector _selector;
        private readonly SelectedConnectionState _state;
        private readonly ILogger<CloseLoadService> _log;

        public CloseLoadService(IConnectionSelector selector, SelectedConnectionState state, ILogger<CloseLoadService> log)
        {
            _selector = selector;
            _state = state;
            _log = log;
        }

        private AppDbContext CreateDb(String station)
        {
            var all = _selector.GetConnections();
            var item = all.FirstOrDefault(x => x.name == station) ?? all.FirstOrDefault();

            var cs = item is not null
                ? _selector.BuildConnectionString(item)
                : throw new InvalidOperationException("No hay conexión seleccionada.");

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(cs)
                .Options;

            return new AppDbContext(options);
        }

        public async Task<string> GetDbInfoAsync(string station,CancellationToken ct = default)
        {
            try
            {
                await using var db = CreateDb(station);
                await db.Database.OpenConnectionAsync(ct);

                var conn = db.Database.GetDbConnection();
                return $" {conn.Database} | {conn.DataSource}";
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    "Error al validar conexión con la base de datos.",
                    ex);
            }
        }
        public async Task<List<DispensaryDto>> GetDispensariosAsync(string station, CancellationToken ct)
        {

            await using var db = CreateDb(station);
            var conn = db.Database.GetDbConnection();

            var list = await db.tblDispensarios
                .AsNoTracking()
                .OrderBy(d => d.intDispensario)
                .Select(d => new DispensaryDto
                {
                    DispensaryId = d.intDispensario
                })
                .ToListAsync(ct);

            return list;
        }
        public async Task<IReadOnlyList<BinnacleDto>> GetBinnacleTopAsync(string station, int dispensaryId,CancellationToken ct = default)
        {
                await using var db = CreateDb(station);
                var conn = db.Database.GetDbConnection();
                var fromDate = DateTime.Now.AddHours(-24);

                var query = db.tblBitacoras
                    .AsNoTracking()
                    .Where(b => b.datFechaHora.HasValue &&
                                b.datFechaHora.Value >= fromDate);

                if (dispensaryId != 0)
                {
                    query = query.Where(b =>
                        b.intDispensario.HasValue &&
                        b.intDispensario.Value == dispensaryId);
                }

                var list = await query
                    .OrderByDescending(b => b.intSecuencia)
                    .Take(7)
                    .Select(b => new BinnacleDto
                    {
                        id = b.intSecuencia,
                        Date = b.datFechaHora,

                        Observations = b.strObservaciones,
                        Scheduled = (double?)b.dblProgramado,
                        Sold = (double?)b.dblVendido,
                        SoldVolume = (double?)b.dblVolumenVendido,
                        UnitPrice = (double?)b.dblPrecioUnitario,
                        Closed = b.bitCerrada,

                        DispensaryId = b.intDispensario,
                        HoseId = b.intManguera,
                        ProductId = b.intProducto,

                        Totalizator = b.strTotalizador,
                        OriginTotalizator = b.strTotalizadorOriginal,
                        EndTotalizator = b.strTotalizadorFinalOriginal
                    })
                    .ToListAsync(ct);

                return list;
        }


        public async Task<IReadOnlyList<TransactionDto>> GetTransactionsTopAsync(string station, int dispensaryId, CancellationToken ct = default)
        {
            await using var db = CreateDb(station);

            var fromDate = DateTime.Today.AddDays(-1);

            var query = db.tblTransacciones
                .AsNoTracking()
                .Where(t => t.datFechahora >= fromDate);

            // si quieres permitir 0 = todos
            if (dispensaryId != 0)
                query = query.Where(t => t.intDispensario == dispensaryId);

            var list = await query
                .OrderByDescending(t => t.intSecuencia)
                .Take(7)
                .Select(t => new TransactionDto
                {
                    id = (int)t.intSecuencia,          // intSecuencia es long, tu dto id es int
                    Date = t.datFechahora,
                    Volume = t.dblVolumen,
                    Amount = t.dblImporte,
                    UnitPrice = t.dblPrecioUnitario
                })
                .ToListAsync(ct);

            return list;
        }
        public async Task<TransactionDto?> GetTransactionBySequenceAsync(string station, long secuencia, CancellationToken ct = default)
        {
            await using var db = CreateDb(station);

            return await db.tblTransacciones
                .AsNoTracking()
                .Where(t => t.intSecuencia == secuencia)
                .Select(t => new TransactionDto
                {
                    id = t.intID,                
                    Date = t.datFechahora,
                    Volume = t.dblVolumen,
                    Amount = t.dblImporte,
                    UnitPrice = t.dblPrecioUnitario
                })
                .FirstOrDefaultAsync(ct);
        }

        public async Task CloseManualAsync(string station, int secuenciaBuscar,decimal volumenGross,decimal volumenNetoCt,decimal temperatura,CancellationToken ct = default)
        {
            try
            {

            await using var db = CreateDb(station);

            var pSec = new SqlParameter("@SecuenciaBuscar", secuenciaBuscar);
            var pGross = new SqlParameter("@VolumenGROSS", volumenGross);
            var pNeto = new SqlParameter("@VolumenNetoCT", volumenNetoCt);
            var pTemp = new SqlParameter("@Temperatura", temperatura);

            db.Database.SetCommandTimeout(10000);

            await db.Database.ExecuteSqlRawAsync(
                "EXEC dbo.sp_Binnacle_CloseManual @SecuenciaBuscar, @VolumenNetoCT,@VolumenGROSS, @Temperatura",
                new object[] { pSec, pNeto, pGross, pTemp },
                ct);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       public async Task<decimal> GetNetVolAutoAsync(string station ,int intDispensario,int intProducto,decimal temperatura,decimal volumenGross,CancellationToken ct = default)
        {
            await using var db = CreateDb(station);

            var pDisp = new SqlParameter("@intDispensario", intDispensario);
            var pProd = new SqlParameter("@intProducto", intProducto);
            var pTemp = new SqlParameter("@Temperatura", temperatura);
            var pGross = new SqlParameter("@VolumenGross", volumenGross);

            db.Database.SetCommandTimeout(10000);

            var sql = @"
                        SELECT dbo.fn_VolumenCorregido(
                            @intDispensario,
                            @intProducto,
                            @Temperatura,
                            @VolumenGross
                        )AS Value";

            var result = await db.Database
                .SqlQueryRaw<decimal>(sql, pDisp, pProd, pTemp, pGross)
                .SingleAsync(ct);

            return result;
        }
       
    }

}
