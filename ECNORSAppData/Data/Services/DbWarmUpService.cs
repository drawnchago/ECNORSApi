using ECNORSAppData.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public sealed class DbWarmupHostedService : IHostedService
{
    private readonly ICloseLoadService _svc;
    private readonly ILogger<DbWarmupHostedService> _log;

    public DbWarmupHostedService(ICloseLoadService svc, ILogger<DbWarmupHostedService> log)
        => (_svc, _log) = (svc, log);

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        try
        {
            // Aquí elige una estación “default” o las más usadas
            var station = "ESTACION_1";

            _log.LogInformation("DB Warmup START | {station}", station);
            await _svc.GetDbInfoAsync(station, cancellationToken);
            _log.LogInformation("DB Warmup END | {station}", station);
        }
        catch (Exception ex)
        {
            _log.LogWarning(ex, "DB Warmup FAILED (no bloquea el arranque)");
        }
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}