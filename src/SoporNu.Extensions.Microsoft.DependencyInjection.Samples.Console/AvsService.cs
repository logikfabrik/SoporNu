using Microsoft.Extensions.Hosting;

namespace SoporNu.Extensions.Microsoft.DependencyInjection.Samples.Console
{
    internal sealed class AvsService(ISoporApiClient client) : IHostedService
    {
        private readonly ISoporApiClient _client = client;

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            foreach (var avs in await _client.GetAllAvs(cancellationToken))
            {
                System.Console.WriteLine($"{avs.Municipality.Name}: {avs.PrimaryName ?? avs.SecondaryName}");
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}