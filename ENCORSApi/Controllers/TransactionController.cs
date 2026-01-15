using ECNORSAppData.Services;
using Microsoft.AspNetCore.Mvc;

namespace ENCORSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class TransactionController : ControllerBase
{
    private readonly ICloseLoadService _svc;

    public TransactionController(ICloseLoadService svc) => _svc = svc;

    [HttpGet("top")]
    public async Task<IActionResult> Top([FromQuery] int dispensaryId, CancellationToken ct)
    {
        var list = await _svc.GetTransactionsTopAsync(dispensaryId, ct);
        return Ok(list);
    }

    [HttpGet("by-sequence/{secuencia:long}")]
    public async Task<IActionResult> BySequence(long secuencia, CancellationToken ct)
    {
        var item = await _svc.GetTransactionBySequenceAsync(secuencia, ct);
        return item is null ? NotFound() : Ok(item);
    }
}
