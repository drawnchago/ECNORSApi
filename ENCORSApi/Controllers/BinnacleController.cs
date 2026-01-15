using ECNORSAppData.Services;
using ENCORSApi.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace ENCORSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class BinnacleController : ControllerBase
{
    private readonly ICloseLoadService _svc;
    private readonly ILogger<BinnacleController> _log;

    public BinnacleController(ICloseLoadService svc, ILogger<BinnacleController> log) {
        _svc = svc;
        _log = log;
    }

    [HttpGet("top")]
    public async Task<IActionResult> Top([FromQuery] int dispensaryId, CancellationToken ct)
    {
        try
        {
            _log.LogInformation("Binnacle.Top start | dispensaryId={DispensaryId}", dispensaryId);

            var list = await _svc.GetBinnacleTopAsync(dispensaryId, ct);

            _log.LogInformation("Binnacle.Top ok | count={Count}", list.Count);

            return Ok(new
            {
                Success = true,
                Message = "Bitácora obtenida correctamente",
                Data = list
            });
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "Binnacle.Top error | dispensaryId={DispensaryId}", dispensaryId);

            return StatusCode(500, new
            {
                Success = false,
                Message = "Error al obtener la bitácora"+"Error=>"+ ex.Message
            });
        }
    }

    [HttpPost("close-manual")]
    public async Task<IActionResult> CloseManual([FromBody] CloseManualRequest req, CancellationToken ct)
    {
        try
        {
            _log.LogInformation("Binnacle.CloseManual start | Secuencia={Secuencia} | Totalizador={Totalizador} | Gross={Gross} | Neto={Neto} | Temp={Temp}",req.SecuenciaBuscar,req.Totalizador,req.VolumenGross,req.VolumenNetoCt,req.Temperatura);

            await _svc.CloseManualAsync(req.SecuenciaBuscar,req.Totalizador,req.VolumenGross,req.VolumenNetoCt,req.Temperatura,ct);

            _log.LogInformation("Binnacle.CloseManual ok | Secuencia={Secuencia}",req.SecuenciaBuscar);

            return Ok(new
            {
                success = true,
                message = "Cierre manual ejecutado correctamente"
            });
        }
        catch (Exception ex)
        {
            _log.LogError(ex,"Binnacle.CloseManual error | Secuencia={Secuencia}",req.SecuenciaBuscar);

            return StatusCode(500, new
            {
                success = false,
                message = "Error al ejecutar cierre manual => " + ex.Message
            });
        }
    }
}
