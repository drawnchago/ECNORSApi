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

    public DispensaryController(ICloseLoadService svc,ILogger<DispensaryController> log)
    {
        _svc = svc;
        _log = log;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] string station, CancellationToken ct)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(station))
                return BadRequest(new { success = false, message = "El parámetro 'station' es requerido." });

            _log.LogInformation("Dispensarios.Get start | station={Station}", station);

            var list = await _svc.GetDispensariosAsync(station, ct);

            _log.LogInformation("Dispensarios.Get ok | station={Station} | count={Count}", station, list.Count);

            return Ok(new
            {
                success = true,
                message = "Dispensarios obtenidos correctamente",
                data = list
            });
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "Dispensarios.Get error | station={Station}", station);

            return StatusCode(500, new
            {
                success = false,
                message = "Error al obtener dispensarios => " + ex.Message
            });
        }
    }


}
