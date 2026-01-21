using ECNORSAppData.Services;
using Microsoft.AspNetCore.Mvc;

namespace ENCORSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class StationController : ControllerBase
{
    private readonly ICloseLoadService _svc;
    private readonly ILogger<StationController> _log;

    public StationController(ICloseLoadService svc, ILogger<StationController> log)
    {
        _svc = svc;
        _log = log;
    }

    [HttpGet("db-info")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> DbInfo(String station,CancellationToken ct)
    {
        var aborted = HttpContext.RequestAborted;
        _log.LogInformation("Station.DbInfo start");

        try
        {
            var result = await _svc.GetDbInfoAsync(station,ct);

            if (string.IsNullOrWhiteSpace(result))
            {
                _log.LogWarning("Station.DbInfo | sin información de base de datos");

                return NotFound(new
                {
                    Success = false,
                    Message = "No se pudo obtener información de la base de datos."
                });
            }

            _log.LogInformation("Station.DbInfo ok | result={Result}", result);

            return Ok(new
            {
                Success = true,
                Message = "Conexión establecida | " + result
            });
        }
        catch (OperationCanceledException) when (aborted.IsCancellationRequested)
        {
            _log.LogWarning("Station.DbInfo canceled (OperationCanceledException)");
            return StatusCode(499, new { Success = false, Message = "Solicitud cancelada por el cliente." });
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "Station.DbInfo error");

            return StatusCode(StatusCodes.Status500InternalServerError, new
            {
                Success = false,
                Message = "Error interno al validar conexión con la base de datos."
            });
        }
    }


}
