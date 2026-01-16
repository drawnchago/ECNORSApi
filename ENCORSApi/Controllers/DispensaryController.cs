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
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get([FromQuery] string station, CancellationToken ct)
    {
        if (string.IsNullOrWhiteSpace(station))
        {
            _log.LogWarning("Dispensarios.Get | station vacío o nulo");

            return BadRequest(new
            {
                success = false,
                message = "El parámetro 'station' es obligatorio."
            });
        }
        try
        {
            _log.LogInformation("Dispensarios.Get start | station={Station}", station);

            var list = await _svc.GetDispensariosAsync(station, ct);

            if (list is null || list.Count == 0)
            {
                _log.LogWarning("Dispensarios.Get | sin resultados | station={Station}", station);

                return NotFound(new
                {
                    success = false,
                    message = $"No se encontraron dispensarios para la estación '{station}'.",
                    data = Array.Empty<object>()
                });
            }

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
                message = "Error al obtener dispensarios"
            });
        }
    }


}
