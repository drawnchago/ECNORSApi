using ECNORSAppData.Data.DTO;
using ECNORSAppData.Services;
using ENCORSApi.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
    public async Task<IActionResult> DbInfo(string station, CancellationToken ct)
    {
        var sw = Stopwatch.StartNew();
        _log.LogInformation("DbInfo START | station={station}", station);

        try
        {
            var result = await _svc.GetDbInfoAsync(station, ct);

            sw.Stop();
            _log.LogInformation("DbInfo END OK | station={station} | ms={ms}", station, sw.ElapsedMilliseconds);

            if (string.IsNullOrWhiteSpace(result))
                return NotFound(new { Success = false, Message = "No se pudo obtener información de la base de datos." });

            return Ok(new { Success = true, Message = "Conexión establecida | " + result  + "| ms=" + sw.ElapsedMilliseconds });
        }
        catch (Exception ex)
        {
            sw.Stop();
            _log.LogError(ex, "DbInfo END ERR | station={station} | ms={ms}", station, sw.ElapsedMilliseconds);
            return StatusCode(500, new { Success = false, Message = "Error interno al validar conexión con la base de datos." });
        }
    }
}
