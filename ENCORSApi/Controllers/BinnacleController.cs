using ENCORSApi.Contracts;
using ECNORSAppData.Services;
using Microsoft.AspNetCore.Mvc;

namespace ENCORSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class BinnacleController : ControllerBase
{
    private readonly ICloseLoadService _svc;

    public BinnacleController(ICloseLoadService svc) => _svc = svc;

    [HttpGet("top")]
    public async Task<IActionResult> Top([FromQuery] int dispensaryId, CancellationToken ct)
    {
        var list = await _svc.GetBinnacleTopAsync(dispensaryId, ct);
        return Ok(list);
    }

    [HttpPost("close-manual")]
    public async Task<IActionResult> CloseManual([FromBody] CloseManualRequest req, CancellationToken ct)
    {
        await _svc.CloseManualAsync(
            req.SecuenciaBuscar,
            req.Totalizador,
            req.VolumenGross,
            req.VolumenNetoCt,
            req.Temperatura,
            ct);

        return Ok(new { ok = true });
    }
}
