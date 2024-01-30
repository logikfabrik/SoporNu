using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text.Json.Serialization;

using SoporNu.Models;
using SoporNu.Models.Dtos;

namespace SoporNu
{
    public sealed class SoporApiClient : ISoporApiClient
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

        private static readonly Uri s_defaultBaseUrl = new("https://avfallshubben.avfallsverige.se/umbraco/Api/SoporApi/");

        private readonly HttpClient _httpClient;

        public SoporApiClient(HttpClient? httpClient = null, Uri? baseUrl = null)
        {
            _httpClient = httpClient ?? new HttpClient();

            _httpClient.BaseAddress = baseUrl ?? s_defaultBaseUrl;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));
        }

        public async Task<Avs[]> GetAllAvs(CancellationToken cancellationToken = default)
        {
            using var response = await _httpClient.GetAsync("GetAllAvs", cancellationToken);

            var content = response.EnsureSuccessStatusCode().Content;

            var avs = await content.ReadFromJsonAsync<GetAllAvsResponse>(cancellationToken);

            return avs?.Select(AvsFactory.Create).ToArray() ?? [];
        }

        public async Task<AvsDetails?> GetAvs(MunicipalityCode municipalityCode, ExternalAvsId externalId, CancellationToken cancellationToken = default)
        {
            using var response = await _httpClient.GetAsync($"GetAvs?municipalityCode={municipalityCode}&externalAvsId={externalId}", cancellationToken);

            var content = response.EnsureSuccessStatusCode().Content;

            var avs = (await content.ReadFromJsonAsync<GetAvsResponse>(cancellationToken))?.Avs;

            return avs is null ? throw new HttpRequestException(null, null, HttpStatusCode.NotFound) : AvsDetailsFactory.Create(avs);
        }
    }
}
