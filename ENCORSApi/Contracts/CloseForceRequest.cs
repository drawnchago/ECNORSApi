namespace ENCORSApi.Contracts
{
    public class CloseForceRequest
    {
        public string Station { get; set; } = default!;
        public int IdSec { get; set; }
    }
}
