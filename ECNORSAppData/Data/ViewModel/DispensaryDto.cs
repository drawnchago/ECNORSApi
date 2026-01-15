namespace ECNORSAppData.Data.DTO;

public class DispensaryDto
{
    public int DispensaryId { get; set; }
    public string DisplayName => $"Dispensario # {DispensaryId} ";
}
