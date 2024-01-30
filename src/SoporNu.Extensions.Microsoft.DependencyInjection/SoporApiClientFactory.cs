using Microsoft.Extensions.Options;

namespace SoporNu.Extensions.Microsoft.DependencyInjection
{
    public sealed class SoporApiClientFactory(HttpClient httpClient, IOptions<SoporApiClientOptions> options) : ISoporApiClientFactory
    {
        public ISoporApiClient Create() => new SoporApiClient(httpClient, options.Value.BaseUrl);
    }
}
