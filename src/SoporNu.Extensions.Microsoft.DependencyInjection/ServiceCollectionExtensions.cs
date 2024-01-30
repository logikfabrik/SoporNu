using Microsoft.Extensions.DependencyInjection;

namespace SoporNu.Extensions.Microsoft.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSoporApiClient(this IServiceCollection services)
        {
            services.AddHttpClient<ISoporApiClientFactory, SoporApiClientFactory>();

            services.AddScoped(provider =>
            {
                using var scope = provider.CreateScope();

                var factory = scope.ServiceProvider.GetRequiredService<ISoporApiClientFactory>();

                return factory.Create();
            });

            return services;
        }

        public static IServiceCollection AddSoporApiClient(this IServiceCollection services, Action<SoporApiClientOptions> configureOptions)
        {
            services
                .ConfigureOptions(configureOptions);

            AddSoporApiClient(services);

            return services;
        }

        public static IServiceCollection AddSoporApiClient(this IServiceCollection services, SoporApiClientOptions userOptions)
        {
            services
                .AddOptions<SoporApiClientOptions>()
                .Configure(options =>
                {
                    options.BaseUrl = userOptions.BaseUrl;
                });

            AddSoporApiClient(services);

            return services;
        }
    }
}
