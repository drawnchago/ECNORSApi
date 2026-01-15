namespace ECNORSApi.Config;

public class StationsOptions
{
    public List<StationItem> Stations { get; set; } = new();
}

public class StationItem
{
    public string Name { get; set; } = "";
    public string ConnectionString { get; set; } = "";
}
