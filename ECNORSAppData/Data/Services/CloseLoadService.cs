using ECNORSAppData.Data;
using ECNORSAppData.Data.Config;
using ECNORSAppData.Data.DTO;
using ECNORSAppData.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ECNORSAppData.Services
{
    public interface ICloseLoadService
    {
        Task<IReadOnlyList<DispensaryDto>> GetDispensariosAsync(CancellationToken ct = default);
        Task<string> GetDbInfoAsync(CancellationToken ct = default);
        Task<IReadOnlyList<TransactionDto>> GetTransactionsTopAsync(int dispensaryId, CancellationToken ct = default);
        Task<IReadOnlyList<BinnacleDto>> GetBinnacleTopAsync(int dispensaryId, CancellationToken ct = default); 
        Task<TransactionDto?> GetTransactionBySequenceAsync(long secuencia, CancellationToken ct = default);
        Task CloseManualAsync(int secuenciaBuscar,decimal totalizador,decimal volumenGross,decimal volumenNetoCt,decimal temperatura,CancellationToken ct = default);

    }

    public sealed class CloseLoadService : ICloseLoadService
    {
        private readonly IConnectionSelector _selector;
        private readonly SelectedConnectionState _state;

        public CloseLoadService(IConnectionSelector selector, SelectedConnectionState state)
        {
            _selector = selector;
            _state = state;
        }

        private AppDbContext CreateDb()
        {
            var all = _selector.GetConnections();
            var selectedName = _state.GetSelectedName();
            var item = all.FirstOrDefault(x => x.name == selectedName) ?? all.FirstOrDefault();

            var cs = item is not null
                ? _selector.BuildConnectionString(item)
                : throw new InvalidOperationException("No hay conexión seleccionada.");

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(cs)
                .Options;

            return new AppDbContext(options);
        }

        public async Task<string> GetDbInfoAsync(CancellationToken ct = default)
        {
            try
            {
                await using var db = CreateDb();
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



        public async Task<IReadOnlyList<DispensaryDto>> GetDispensariosAsync(CancellationToken ct = default)
        {
            await using var db = CreateDb();

            return await db.tblDispensarios
                .AsNoTracking()
                .OrderBy(d => d.intDispensario)
                .Select(d => new DispensaryDto
                {
                    DispensaryId = d.intDispensario
                })
                .ToListAsync(ct);
        }

        public async Task<IReadOnlyList<BinnacleDto>> GetBinnacleTopAsync(int dispensaryId, CancellationToken ct = default)
        {
            await using var db = CreateDb();

            var fromDate = DateTime.Today.AddDays(-1);

            return await db.tblBitacoras
                .AsNoTracking()
                .Where(b => b.datFechaHora >= fromDate &&
                            (dispensaryId == 0 || b.intDispensario == dispensaryId))
                .OrderByDescending(b => b.intSecuencia)
                .Take(7)
                .Select(b => new BinnacleDto
                {
                    id = b.intSecuencia,
                    Date = b.datFechaHora,
                    Observations = b.strObservaciones,
                    Scheduled = b.dblProgramado,
                    Sold = b.dblVendido,
                    SoldVolume = b.dblVolumenVendido,
                    UnitPrice = b.dblPrecioUnitario,
                    Closed = b.bitCerrada,

                    Totalizator = b.strTotalizador,
                    OriginTotalizator = b.strTotalizadorOriginal,
                    EndTotalizator = b.strTotalizadorFinalOriginal,

                    DispensaryId = b.intDispensario,
                    HoseId = b.intManguera,
                    ProductId = b.intProducto
                })
                .ToListAsync(ct);
        }

        public async Task<IReadOnlyList<TransactionDto>> GetTransactionsTopAsync(int dispensaryId, CancellationToken ct = default)
        {
            await using var db = CreateDb();

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
        public async Task<TransactionDto?> GetTransactionBySequenceAsync(long secuencia, CancellationToken ct = default)
        {
            await using var db = CreateDb();

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

        public async Task CloseManualAsync(
            int secuenciaBuscar,
            decimal totalizador,
            decimal volumenGross,
            decimal volumenNetoCt,
            decimal temperatura,
            CancellationToken ct = default)
        {
            await using var db = CreateDb();

            var pSec = new SqlParameter("@SecuenciaBuscar", secuenciaBuscar);
            var pTot = new SqlParameter("@Totalizador", totalizador);
            var pGross = new SqlParameter("@VolumenGROSS", volumenGross);
            var pNeto = new SqlParameter("@VolumenNetoCT", volumenNetoCt);
            var pTemp = new SqlParameter("@Temperatura", temperatura);

            db.Database.SetCommandTimeout(120);

            await db.Database.ExecuteSqlRawAsync(
                "EXEC dbo.sp_Binnacle_CloseManual @SecuenciaBuscar, @Totalizador, @VolumenGROSS, @VolumenNetoCT, @Temperatura",
                new object[] { pSec, pTot, pGross, pNeto, pTemp },
                ct);
        }


    }

}
