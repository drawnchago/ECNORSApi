using ECNORSAppData.Data.DTO;
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


    [HttpPost("UpdateTransactionBySequence")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> UpdateTransactionBySequence([FromBody] TransactionUpdateDto req,CancellationToken ct)
    {
        if (req is null)return BadRequest(new { Success = false, Message = "Body requerido." });
        if (string.IsNullOrWhiteSpace(req.Station))return BadRequest(new { Success = false, Message = "Estacion es requerida." });
        if (req.Sequence <= 0)return BadRequest(new { Success = false, Message = "Secuencia es inválida." });

        try
        {
            _log.LogInformation("TransactionController| UpdateTransactionBySequence | Start | Station={Station} | Sequence={Sequence} | Price={Price} | Volume={Volume} | Amount={Amount}", req.Station, req.Sequence, req.UnitPrice, req.Volume, req.Amount);

            var result = await _svc.UpdateTransactionBySequence(req, ct);

            if (!result.Success)
            {
                _log.LogWarning("TransactionController| UpdateTransactionBySequence | BusinessFail | Station={Station} | Sequence={Sequence} | Msg={Msg}", req.Station, req.Sequence, result.Message);

                return BadRequest(new { Success = false, Message = result.Message });
            }

            _log.LogInformation("TransactionController| UpdateTransactionBySequence | End(Ok) | Station={Station} | Sequence={Sequence}", req.Station, req.Sequence);

            return Ok(new { Success = true, Message = result.Message });
        }
        catch (OperationCanceledException)
        {
            _log.LogWarning("TransactionController| UpdateTransactionBySequence | Canceled | Station={Station} | Sequence={Sequence}", req.Station, req.Sequence);
             return StatusCode(499, new { Success = false, Message = "Solicitud cancelada." });
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "TransactionController| UpdateTransactionBySequence | End(Err) | Station={Station} | Sequence={Sequence}", req.Station, req.Sequence);
            return StatusCode(500, new { Success = false, Message = "Error al actualizar la transacción." });
        }
    }


}
