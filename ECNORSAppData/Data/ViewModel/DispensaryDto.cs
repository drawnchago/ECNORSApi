using System.Text.Json.Serialization;

namespace ECNORSAppData.Data.DTO;

public class DispensaryDto
{
    [JsonPropertyName("dispensaryId")]
    public int DispensaryId { get; set; }

    [JsonPropertyName("islaId")]
    public int IslaId { get; set; }

    [JsonPropertyName("secuencia")]
    public int? Secuencia { get; set; }

    [JsonPropertyName("fechaSecuencia")]
    public DateTime? FechaSecuencia { get; set; }

    [JsonPropertyName("generado")]
    public bool Generado { get; set; }

    [JsonPropertyName("sirviendo")]
    public bool Sirviendo { get; set; }

    [JsonPropertyName("despacho")]
    public bool Despacho { get; set; }

    [JsonPropertyName("estatus")]
    public int? Estatus { get; set; }

    [JsonPropertyName("stationName")]
    public string StationName { get; set; } = string.Empty;

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;
}