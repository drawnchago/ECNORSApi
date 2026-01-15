using ECNORSAppData.Services;
using Microsoft.AspNetCore.Mvc;

namespace ENCORSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class StationController : ControllerBase
{
    private readonly ICloseLoadService _svc;

    public StationController(ICloseLoadService svc) => _svc = svc;

[HttpGet("db-info")]
public async Task<IActionResult> DbInfo(CancellationToken ct)
{
    try
    {
        var result = await _svc.GetDbInfoAsync(ct);

        return Ok(new
        {
            success = true,
            message = "Conexión establecida |" + result,
        });
    }
    catch (Exception ex)
    {
        return StatusCode(500, new
        {
            success = false,
            message = ex.Message
        });
    }
}

}
