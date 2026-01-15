namespace ENCORSApi.Contracts;

public sealed class CloseManualRequest
{
    public int SecuenciaBuscar { get; set; }
    public decimal Totalizador { get; set; }
    public decimal VolumenGross { get; set; }
    public decimal VolumenNetoCt { get; set; }
    public decimal Temperatura { get; set; }
}
