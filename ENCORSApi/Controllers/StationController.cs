using ECNORSAppData.Services;
using Microsoft.AspNetCore.Mvc;

namespace ENCORSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class StationController : ControllerBase
{
    private readonly ICloseLoadService _svc;
    private readonly ILogger<StationController> _log;

    public StationController(ICloseLoadService svc, ILogger<StationController> log) => (_svc, _log) = (svc, log);

    [HttpGet("db-info")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> DbInfo(String station,CancellationToken ct)
    {
        var aborted = HttpContext.RequestAborted;
        _log.LogInformation("StationController | DbInfo | Start | Estacion:{station}",station);

        try
        {
            _log.LogInformation("StationController | DbInfo | Try | Estacion:{station}", station);
            var result = await _svc.GetDbInfoAsync(station,ct);

            if (string.IsNullOrWhiteSpace(result))
            {
                _log.LogWarning("StationController | DbInfo | NotFound(result) | Estacion:{station}", station);
                return NotFound( new { Success = false, Message = "No se pudo obtener información de la base de datos." });
            }

            _log.LogInformation("StationController | DbInfo | End(Ok) | Estacion:{station} | Result:{result}", station ,result);
            return Ok( new { Success = true, Message = "Conexión establecida | " + result });
        }
        catch (OperationCanceledException) when (aborted.IsCancellationRequested)
        {
            _log.LogWarning("StationController | DbInfo | End(OperationCanceledException) | Estacion:{station}", station);
            return StatusCode(499, new { Success = false, Message = "Solicitud cancelada por el cliente." });
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "StationController | DbInfo | End(Err) | Estacion:{station}",station);
            return StatusCode(500, new { Success = false, Message = "Error interno al validar conexión con la base de datos." });
        }
    }


}
