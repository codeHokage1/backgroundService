
namespace TestingBgServices
{
    public class SampleBackgroundService : BackgroundService
    {
        private readonly ILogger<BackgroundService> _logger;

        public SampleBackgroundService(ILogger<BackgroundService> logger)
        {
            _logger = logger;
        }
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
