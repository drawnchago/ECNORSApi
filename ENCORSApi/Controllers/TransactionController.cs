using ECNORSAppData.Services;
using Microsoft.AspNetCore.Mvc;

namespace ENCORSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class TransactionController : ControllerBase
{
    private readonly ICloseLoadService _svc;
    private readonly ILogger<TransactionController> _log;

    public TransactionController(ICloseLoadService svc, ILogger<TransactionController> log)
    {
        _svc = svc;
        _log = log;
    }

    [HttpGet("top")]
    public async Task<IActionResult> Top([FromQuery] int dispensaryId,CancellationToken ct)
    {
        try
        {
            _log.LogInformation("Transactions.Top start | dispensaryId={DispensaryId}",dispensaryId);

            var list = await _svc.GetTransactionsTopAsync(dispensaryId, ct);

            _log.LogInformation("Transactions.Top ok | count={Count}",list.Count);

            return Ok(list);
        }
        catch (Exception ex)
        {
            _log.LogError(ex,"Transactions.Top error | dispensaryId={DispensaryId}",dispensaryId);

            return StatusCode(500, "Error al obtener transacciones => " + ex.Message);
        }
    }

    [HttpGet("by-sequence/{secuencia:long}")]
    public async Task<IActionResult> BySequence(long secuencia,CancellationToken ct)
    {
        try
        {
            _log.LogInformation("Transactions.BySequence start | secuencia={Secuencia}",secuencia);

            var item = await _svc.GetTransactionBySequenceAsync(secuencia, ct);

            if (item is null)
            {
                _log.LogWarning("Transactions.BySequence not found | secuencia={Secuencia}",secuencia);

                return NotFound();
            }

            _log.LogInformation("Transactions.BySequence ok | secuencia={Secuencia}",secuencia);

            return Ok(item);
        }
        catch (Exception ex)
        {
            _log.LogError(ex,"Transactions.BySequence error | secuencia={Secuencia}",secuencia);

            return StatusCode(500, "Error al obtener transacción => " + ex.Message);
        }
    }

}
