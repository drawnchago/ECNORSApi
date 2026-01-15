namespace ECNORSAppData.Data.DTO;

public class BinnacleDto
{
    public int id { get; set; }
    public DateTime? Date { get; set; }
    public string? Observations { get; set; }
    public double? Scheduled { get; set; }
    public double? Sold { get; set; }
    public double? SoldVolume { get; set; }
    public double? UnitPrice { get; set; }
    public bool? Closed { get; set; }
    public double? Temperature { get; set; }
    public int? DispensaryId { get; set; }
    public int? HoseId { get; set; }
    public int? ProductId { get; set; }
    public string? Totalizator { get; set; }
    public decimal? OriginTotalizator { get; set; }
    public decimal? EndTotalizator { get; set; }
}
