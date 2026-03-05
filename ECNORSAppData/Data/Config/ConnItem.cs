using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ECNORSAppData.Data.Config;

public interface IConnectionSelector
{
    IReadOnlyList<ConnItem> GetConnections();
    string BuildConnectionString(ConnItem item);
}

public class ConnItem
{
    public string name { get; set; } = "";
    public string ip { get; set; } = "";
    public string bd { get; set; } = "";
    public string user { get; set; } = "";
    public string pass { get; set; } = "";
}

public class ConnectionSelector : IConnectionSelector
{
    private readonly IConfiguration _cfg;

    public ConnectionSelector(IConfiguration cfg) => _cfg = cfg;

    public IReadOnlyList<ConnItem> GetConnections()
    {
        var section = _cfg.GetSection("Conn");
        var children = section.GetChildren();

        var list = new List<ConnItem>();
        foreach (var c in children)
        {
            list.Add(new ConnItem
            {
                name = c["name"] ?? "",
                ip = c["ip"] ?? "",
                bd = c["bd"] ?? "",
                user = c["user"] ?? "",
                pass = c["pass"] ?? ""
            });
        }

        return list;
    }

    public string BuildConnectionString(ConnItem item)
    {
        var builder = new SqlConnectionStringBuilder
        {
            DataSource = item.ip,
            InitialCatalog = item.bd,
            UserID = item.user,
            Password = item.pass,
            TrustServerCertificate = true,
            MinPoolSize = 1
        };

        return builder.ConnectionString;
    }

}
