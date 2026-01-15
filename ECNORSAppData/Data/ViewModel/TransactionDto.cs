namespace ECNORSAppData.Data.DTO;

public class TransactionDto
{
    public long id { get; set; }
    public DateTime? Date { get; set; }
    public double? Volume { get; set; }
    public double? Amount { get; set; }
    public double? UnitPrice { get; set; }
}
