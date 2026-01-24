using ECNORSAppData.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ENCORSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class TransactionController : ControllerBase
{
    private readonly ICloseLoadService _svc;
    private readonly ILogger<TransactionController> _log;

    public TransactionController(ICloseLoadService svc, ILogger<TransactionController> log) => (_svc, _log) = (svc, log);

    [HttpGet("top")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Top([FromQuery] string station,int dispensaryId,CancellationToken ct)
    {
        _log.LogInformation("TransactionController | Top |  Start | Estacion: {station} |  dispensaryId: {DispensaryId}", station, dispensaryId);

        if (dispensaryId <= 0)
        {
            _log.LogWarning("TransactionController | Top |  BadRequest | Estacion: {station} |  dispensaryId: {DispensaryId}", station, dispensaryId);
            return BadRequest(new { Success = false, Message = "El parámetro dispensaryId debe ser diferente de cero." });
        }

        try
        {
            _log.LogInformation("TransactionController | Top |  Try | Estacion: {station} |  dispensaryId: {DispensaryId}", station, dispensaryId);
            var list = await _svc.GetTransactionsTopAsync(station,dispensaryId, ct);

            if (list is null || list.Count == 0)
            {
                _log.LogWarning("TransactionController | Top |  ListIsNull | Estacion: {station} |  dispensaryId: {DispensaryId}", station, dispensaryId);
                return NotFound(new { Success = false, Message = $"No se encontraron transacciones para el dispensario {dispensaryId}.", Data = Array.Empty<object>() });
            }

            _log.LogInformation("TransactionController | Top |  End(Ok) | Estacion: {station} |  dispensaryId: {DispensaryId}", station, dispensaryId);
            return Ok(new { Success = true, Message = "Transacciones obtenidas correctamente", Data = list });

        }catch (Exception ex)
        {
            _log.LogError(ex, "TransactionController | Top |  End(Err) | Estacion: {station} |  dispensaryId: {DispensaryId}", station, dispensaryId);
            return StatusCode(500, "Error al obtener transacciones");
        }
    }

    [HttpGet("by-sequence/{secuencia:long}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> BySequence(string station,long secuencia,CancellationToken ct)
    {
        _log.LogInformation("TransactionController | BySequence | Start | Station: {station} | Secuencia: {Secuencia}", station, secuencia);

        if (secuencia <= 0)
        {
            _log.LogWarning("TransactionController | BySequence | BadRequest(secuencia) | Station: {station} | Secuencia: {Secuencia}", station,secuencia);
            return BadRequest(new { Success = false, Message = "La secuencia debe ser diferente de cero." });
        }

        try
        {
            _log.LogInformation("TransactionController| BySequence | Try | Station: {station} | Secuencia: {Secuencia}", station, secuencia);
            var item = await _svc.GetTransactionBySequenceAsync(station,secuencia, ct);

            if (item is null)
            {
                _log.LogWarning("TransactionController | BySequence | NotFound(ItemIsNull) | Station: {station} | Secuencia: {Secuencia}", station, secuencia);
                return NotFound(new { Success = false, Message = $"No se encontró la transacción con secuencia {secuencia}.", Data = (object?)null });
            }

            _log.LogInformation("TransactionController | BySequence | End(Ok) | Station: {station} | Secuencia: {Secuencia}", station, secuencia);
            return Ok(item);

        }catch (Exception ex)
        {
            _log.LogError(ex, "TransactionController | BySequence | End(Err) | Station: {station} | Secuencia: {Secuencia}", station, secuencia);
            return StatusCode(500, "Error al obtener transacción por secuencia");
        }
    }

}
