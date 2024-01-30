using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using SoporNu.Extensions.Microsoft.DependencyInjection;
using SoporNu.Extensions.Microsoft.DependencyInjection.Samples.Console;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddSoporApiClient();
        services.AddHostedService<AvsService>();
    })
    .Build();

await host.RunAsync();