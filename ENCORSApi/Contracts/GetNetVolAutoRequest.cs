namespace ENCORSApi.Contracts;

public sealed class GetNetVolAutoRequest
{
    public string station { get; set; }
    public int IntDispensario { get; set; }
    public int IntProducto { get; set; }
    public decimal Temperatura { get; set; }
    public decimal VolumenGross { get; set; }
}
