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
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Top([FromQuery] int dispensaryId, CancellationToken ct)
    {
        if (dispensaryId <= 0)
        {
            _log.LogWarning("Binnacle.Top | dispensaryId inválido: {DispensaryId}", dispensaryId);

            return BadRequest(new
            {
                Success = false,
                Message = "El parámetro 'dispensaryId' debe ser mayor a cero."
            });
        }

        try
        {
            _log.LogInformation("Binnacle.Top start | dispensaryId={DispensaryId}", dispensaryId);

            var list = await _svc.GetBinnacleTopAsync(dispensaryId, ct);

            if (list is null || list.Count == 0)
            {
                _log.LogWarning("Binnacle.Top | sin resultados | dispensaryId={DispensaryId}", dispensaryId);

                return NotFound(new
                {
                    Success = false,
                    Message = $"No se encontró bitácora para el dispensario {dispensaryId}.",
                    Data = Array.Empty<object>() // o quítalo si no quieres Data en 404
                });
            }

            _log.LogInformation("Binnacle.Top ok | dispensaryId={DispensaryId} | count={Count}", dispensaryId, list.Count);

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
                Message = "Error al obtener la bitácora top"
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
                message = "Error al ejecutar cierre manual"
            });
        }
    }
}
