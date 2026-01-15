using ECNORSApi.Config;
using ECNORSAppData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ECNORSApi.Factories;

public interface IStationDbFactory
{
    AppDbContext Create(string stationName);
}

public sealed class StationDbFactory : IStationDbFactory
{
    private readonly StationsOptions _opt;

    public StationDbFactory(IOptions<StationsOptions> opt)
        => _opt = opt.Value;

    public AppDbContext Create(string stationName)
    {
        var station = _opt.Stations.FirstOrDefault(s =>
            s.Name.Equals(stationName, StringComparison.OrdinalIgnoreCase));

        if (station is null)
            throw new InvalidOperationException("Estación inválida.");

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(station.ConnectionString, o => o.CommandTimeout(15))
            .Options;

        return new AppDbContext(options);
    }
}
