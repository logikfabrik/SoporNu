using System.Net.Http.Json;

namespace SoporNu
{
    internal class SoporApiClient : ISoporApiClient
    {
        private readonly HttpClient _httpClient;

        public SoporApiClient(HttpClient httpClient)
        {
            ArgumentNullException.ThrowIfNull(httpClient, nameof(httpClient));

            _httpClient = httpClient;
        }

        public async Task<Avs[]> GetAllAvs(CancellationToken cancellationToken = default)
        {
            using var response = await _httpClient.GetAsync("GetAllAvs/", cancellationToken);

            var content = response.EnsureSuccessStatusCode().Content;

            var avs = await content.ReadFromJsonAsync<AvsDto[]?>(cancellationToken: cancellationToken);

            return avs?.Select(avs => AvsFactory.Create(avs)).ToArray() ?? [];
        }
    }
}
