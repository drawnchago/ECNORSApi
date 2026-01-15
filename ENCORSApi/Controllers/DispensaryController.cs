using ECNORSAppData.Services;
using Microsoft.AspNetCore.Mvc;

namespace ENCORSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class DispensaryController : ControllerBase
{
    private readonly ICloseLoadService _svc;

    public DispensaryController(ICloseLoadService svc) => _svc = svc;

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken ct)
    {
        var list = await _svc.GetDispensariosAsync(ct);
        return Ok(list);
    }
}
