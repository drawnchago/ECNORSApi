using ECNORSAppData.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ENCORSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class DispensaryController : ControllerBase
{
    private readonly ICloseLoadService _svc;
    private readonly ILogger<DispensaryController> _log;

    public DispensaryController(ICloseLoadService svc, ILogger<DispensaryController> log) => (_svc, _log) = (svc, log);

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get([FromQuery] string station, CancellationToken ct)
    {
        _log.LogInformation("DispensaryController | Get | Start | Estation {station} ", station);

        if (string.IsNullOrWhiteSpace(station))
        {
            _log.LogWarning("DispensaryController | Get | BadRequest(StationIsNull) | Estation {station} ", station);
            return BadRequest(new { Success = false, Message = "El parámetro 'station' es obligatorio."});
        }

        try
        {
            _log.LogInformation("DispensaryController | Get | Try| Estation {station} ", station);
            var list = await _svc.GetDispensariosAsync(station, ct);

            if (list is null || list.Count == 0)
            {
                _log.LogWarning("DispensaryController | Get | NotFound(ListIsNull) | Estation {station} ", station);
                return NotFound( new{ Success = false, Message = $"No se encontraron dispensarios para la estación '{station}'.", Data = Array.Empty<object>() });
            }

            _log.LogInformation("DispensaryController | Get | End(Ok) | Estation {station} ", station);
            return Ok( new{ Success = true, Message = "Dispensarios obtenidos correctamente", Data = list});
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "DispensaryController | Get | End(Ok) | Estation {station} ", station);
            return StatusCode(500, new { Success = false, Message = "Error al obtener dispensarios" });
        }
    }


}
