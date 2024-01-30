using Microsoft.Extensions.Options;

namespace SoporNu.Extensions.Microsoft.DependencyInjection
{
    public sealed class SoporApiClientFactory(HttpClient httpClient, IOptions<SoporApiClientOptions> options) : ISoporApiClientFactory
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly Uri? _baseUrl = options.Value.BaseUrl;

        public ISoporApiClient Create() => new SoporApiClient(_httpClient, _baseUrl);
    }
}
