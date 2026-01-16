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
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Top([FromQuery] int dispensaryId,CancellationToken ct)
    {
        if (dispensaryId <= 0)
        {
            _log.LogWarning("Transactions.Top | dispensaryId inválido: {DispensaryId}", dispensaryId);

            return BadRequest(new
            {
                success = false,
                message = "El parámetro dispensaryId debe ser diferente de cero."
            });
        }

        try
        {
            _log.LogInformation("Transactions.Top start | dispensaryId={DispensaryId}",dispensaryId);

            var list = await _svc.GetTransactionsTopAsync(dispensaryId, ct);

            if (list is null || list.Count == 0)
            {
                _log.LogWarning("Transactions.Top | sin resultados | dispensaryId={DispensaryId}", dispensaryId);

                return NotFound(new
                {
                    success = false,
                    message = $"No se encontraron transacciones para el dispensario {dispensaryId}.",
                    data = Array.Empty<object>()
                });
            }

            _log.LogInformation("Transactions.Top ok | dispensaryId={DispensaryId} | count={Count}", dispensaryId, list.Count);

            return Ok(list);
        }
        catch (Exception ex)
        {
            _log.LogError(ex,"Transactions.Top error | dispensaryId={DispensaryId}",dispensaryId);

            return StatusCode(500, "Error al obtener transacciones");
        }
    }

    [HttpGet("by-sequence/{secuencia:long}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> BySequence(long secuencia,CancellationToken ct)
    {
        if (secuencia <= 0)
        {
            _log.LogWarning("Transactions.BySequence | secuencia inválida: {Secuencia}", secuencia);

            return BadRequest(new
            {
                success = false,
                message = "La secuencia debe ser diferente de cero."
            });
        }

        try
        {
            _log.LogInformation("Transactions.BySequence start | secuencia={Secuencia}",secuencia);

            var item = await _svc.GetTransactionBySequenceAsync(secuencia, ct);

            if (item is null)
            {
                _log.LogWarning("Transactions.BySequence not found | secuencia={Secuencia}", secuencia);

                return NotFound(new
                {
                    success = false,
                    message = $"No se encontró la transacción con secuencia {secuencia}.",
                    data = (object?)null
                });
            }

            _log.LogInformation("Transactions.BySequence ok | secuencia={Secuencia}", secuencia);

            return Ok(item);
        }
        catch (Exception ex)
        {
            _log.LogError(ex,"Transactions.BySequence error | secuencia={Secuencia}",secuencia);

            return StatusCode(500, "Error al obtener transacción por secuencia");
        }
    }

}
