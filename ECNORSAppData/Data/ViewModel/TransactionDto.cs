namespace ECNORSAppData.Data.DTO;

public class TransactionDto
{
    public long id { get; set; }
    public DateTime? Date { get; set; }
    public double? Volume { get; set; }
    public double? Amount { get; set; }
    public double? UnitPrice { get; set; }
}
public sealed class TransactionUpdateDto
{
    public string Station { get; set; }
    public long Sequence { get; set; }     
    public double UnitPrice { get; set; } 
    public double Volume { get; set; }
    public double Amount { get; set; } 
}
public sealed  class TransactionResp<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }

    public static TransactionResp<T> Ok(T data, string? msg = null) => new() { Success = true, Data = data, Message = msg };
    public static TransactionResp<T> Fail(string msg) => new() { Success = false, Message = msg };
}