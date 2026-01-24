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

    public BinnacleController(ICloseLoadService svc, ILogger<BinnacleController> log)=> (_svc, _log) = (svc, log);

    /*OBTIENE EL TOP 7 DE TBLBITACORAS*/
    [HttpGet("top")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Top([FromQuery] string station,int dispensaryId, CancellationToken ct)
    {
        _log.LogInformation("BinnacleController | Top | Start | Estacion={station} | dispensaryId={DispensaryId}", station ,dispensaryId);

        if (dispensaryId <= 0)
        {
            _log.LogWarning("BinnacleController | Top | dispensaryIsNUll | Estacion={station} | dispensaryId inválido: {DispensaryId}", station, dispensaryId);
            return BadRequest(new { Success = false, Message = "El parámetro 'dispensaryId' debe ser mayor a cero."});
        }

        try
        {
            _log.LogInformation("BinnacleController | Top | Try | Estacion={station} | Id={DispensaryId} ", station, dispensaryId);
            var list = await _svc.GetBinnacleTopAsync(station, dispensaryId, ct);

            if (list is null || list.Count == 0)
            {
                _log.LogWarning("BinnacleController | Top | NotFound(List) | Estacion={station} | dispensaryId={DispensaryId}", station, dispensaryId);
                return NotFound(new{ Success = false, Message = $"No se encontró bitácora para el dispensario {dispensaryId}.",Data = Array.Empty<object>()});
            }

            _log.LogInformation("BinnacleController | Top | End(Ok) | Estacion={station} | Id={DispensaryId} | count={Count}", station, dispensaryId, list.Count);
            return Ok(new{ Success = true, Message = "Bitácora obtenida correctamente",Data = list});
        
        }catch (Exception ex)
        {
            _log.LogError(ex, "BinnacleController | Top | End(Err) | dispensary| Estacion={station} | Id={DispensaryId}", station,dispensaryId);
            return StatusCode(500, new { Success = false, Message = "Error al obtener la bitácora top"});
        }
    }

    /*REALIZA CIERRE DE CARGA MANUALES*/
    [HttpPost("close-manual")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> CloseManual([FromBody] CloseManualRequest req, CancellationToken ct)
    {
        try
        {
            _log.LogInformation("BinnacleController | CloseManual |  Start | Secuencia={Secuencia} | Gross={Gross} | Neto={Neto} | Temp={Temp}", req.SecuenciaBuscar,req.VolumenGross,req.VolumenNetoCt,req.Temperatura);
            await _svc.CloseManualAsync(req.station,req.SecuenciaBuscar,req.VolumenGross,req.VolumenNetoCt,req.Temperatura,ct);

            _log.LogInformation("BinnacleController | CloseManual | End(Ok) | Secuencia={Secuencia} | Gross={Gross} | Neto={Neto} | Temp={Temp}", req.SecuenciaBuscar, req.VolumenGross, req.VolumenNetoCt, req.Temperatura);
            return Ok(new { Success = true, Message = "Cierre manual ejecutado correctamente" });
        
        }catch (Exception ex)
        {
            _log.LogError(ex, "BinnacleController | CloseManual | End(Err) | Secuencia={Secuencia} | Gross={Gross} | Neto={Neto} | Temp={Temp}", req.SecuenciaBuscar, req.VolumenGross, req.VolumenNetoCt, req.Temperatura);
            return StatusCode(500, new{ Success = false, Message = "Error al ejecutar cierre manual" });
        }
    }

    /*OBTIENE EL VOLUMEN NETO AUTOMATICAMENTE*/
    [HttpPost("GetNetVolAuto")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetNetVolAuto([FromBody] GetNetVolAutoRequest req, CancellationToken ct)
    {
        try
        {
            _log.LogInformation("BinnacleController| GetNetVolAuto | Start | Estacion={station} | Dispensario={Disp} | Producto={Prod} | Gross={Gross} | Temp={Temp}", req.station , req.IntDispensario, req.IntProducto, req.VolumenGross, req.Temperatura);
            var neto = await _svc.GetNetVolAutoAsync(req.station,req.IntDispensario,req.IntProducto,req.Temperatura,req.VolumenGross,ct);

            _log.LogInformation("BinnacleController| GetNetVolAuto | End(Ok) | Estacion={station} | Dispensario={Disp} | Producto={Prod} | Neto={Neto}", req.station, req.IntDispensario, req.IntProducto, neto);
            return Ok( new{ Success = true, Message = "Volumen Neto calculado correctamente",data = neto });

        }catch (Exception ex)
        {
            _log.LogError(ex, "BinnacleController| GetNetVolAuto | End(Err) | Estacion={station} | Dispensario={Disp} | Producto={Prod}", req.station, req.IntDispensario, req.IntProducto);
            return StatusCode(500, new{ Success = false, Message = "Error al calcular volumen neto" });
        }
    }
}
