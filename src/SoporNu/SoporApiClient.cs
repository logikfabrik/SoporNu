using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace SoporNu
{
    internal class SoporApiClient : ISoporApiClient
    {
        private class GetAllAvsResponse : List<AvsDto>;

        private class GetAvsResponse
        {
            [JsonPropertyName("avs")]
            public AvsDto? Avs { get; set; }

            [JsonPropertyName("disableServiceRequestReportingToUser")]
            public bool DisableServiceRequestReportingToUser { get; set; }

            [JsonPropertyName("customServiceRequestUrl")]
            public string? CustomServiceRequestUrl { get; set; }
        }

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

            var avs = await content.ReadFromJsonAsync<GetAllAvsResponse>(cancellationToken);

            return avs?.Select(AvsFactory.Create).ToArray() ?? [];
        }

        public async Task<AvsDetails?> GetAvs(MunicipalityCode municipalityCode, ExternalAvsId externalId, CancellationToken cancellationToken = default)
        {
            using var response = await _httpClient.GetAsync($"GetAvs?municipalityCode={municipalityCode}&externalAvsId={externalId}", cancellationToken);

            var content = response.EnsureSuccessStatusCode().Content;

            var avs = (await content.ReadFromJsonAsync<GetAvsResponse>(cancellationToken))?.Avs;

            return avs is null ? null : AvsDetailsFactory.Create(avs);
        }
    }
}
