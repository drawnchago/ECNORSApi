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
    public async Task<IActionResult> DbInfo(CancellationToken ct)
    {
        try
        {
            _log.LogInformation("Station.DbInfo start");

            var result = await _svc.GetDbInfoAsync(ct);

            _log.LogInformation("Station.DbInfo ok | result={Result}", result);

            return Ok(new
            {
                Success = true,
                Message = "Conexión establecida | " + result,
            });
        }catch (Exception ex)
        {
            _log.LogError(ex, "Station.DbInfo error");

            return StatusCode(500, new
            {
                Success = false,
                Message = ex.Message
            });
        }
    }


}
