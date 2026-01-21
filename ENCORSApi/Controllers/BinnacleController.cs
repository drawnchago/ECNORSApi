using ECNORSAppData.Services;
using ENCORSApi.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using static System.Collections.Specialized.BitVector32;

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
    public async Task<IActionResult> Top([FromQuery] string station,int dispensaryId, CancellationToken ct)
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

            var list = await _svc.GetBinnacleTopAsync(station, dispensaryId, ct);

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
            _log.LogInformation("Binnacle.CloseManual start | Secuencia={Secuencia} | Gross={Gross} | Neto={Neto} | Temp={Temp}",req.SecuenciaBuscar,req.VolumenGross,req.VolumenNetoCt,req.Temperatura);

            await _svc.CloseManualAsync(req.station,req.SecuenciaBuscar,req.VolumenGross,req.VolumenNetoCt,req.Temperatura,ct);

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

    [HttpPost("GetNetVolAuto")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetNetVolAuto([FromBody] GetNetVolAutoRequest req, CancellationToken ct)
    {
        try
        {
            _log.LogInformation(
                "Binnacle.GetNetVolAuto start | Dispensario={Disp} | Producto={Prod} | Gross={Gross} | Temp={Temp}",
                req.IntDispensario, req.IntProducto, req.VolumenGross, req.Temperatura);

            var neto = await _svc.GetNetVolAutoAsync(
                req.station,
                req.IntDispensario,
                req.IntProducto,
                req.Temperatura,
                req.VolumenGross,
                ct);

            _log.LogInformation(
                "Binnacle.GetNetVolAuto ok | Dispensario={Disp} | Producto={Prod} | Neto={Neto}",
                req.IntDispensario, req.IntProducto, neto);

            return Ok(new
            {
                success = true,
                message = "Volumen Neto calculado correctamente",
                data = neto
            });
        }
        catch (Exception ex)
        {
            _log.LogError(
                ex,
                "Binnacle.GetNetVolAuto error | Dispensario={Disp} | Producto={Prod}",
                req.IntDispensario, req.IntProducto);

            return StatusCode(500, new
            {
                success = false,
                message = "Error al calcular volumen neto"
            });
        }
    }


}
