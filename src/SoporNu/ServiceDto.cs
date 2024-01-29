using System.Text.Json.Serialization;

namespace SoporNu
{
    internal class ServiceDto
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("avsId")]
        public string? AvsId { get; set; }

        [JsonPropertyName("externalAvsId")]
        public string? ExternalAvsId { get; set; }

        [JsonPropertyName("municipalityCode")]
        public string? MunicipalityCode { get; set; }

        [JsonPropertyName("serviceId")]
        public string? ServiceId { get; set; }

        [JsonPropertyName("serviceType")]
        public int ServiceType { get; set; }

        [JsonPropertyName("lastAction")]
        public DateTime? LastAction { get; set; }

        [JsonPropertyName("lastActionAltText")]
        public string? LastActionAlternativeText { get; set; }

        [JsonPropertyName("nextAction")]
        public DateTime? NextAction { get; set; }

        [JsonPropertyName("nextActionAltText")]
        public string? NextActionAlternativeText { get; set; }

        [JsonPropertyName("extraInfo")]
        public string? ExtraInformation { get; set; }

        [JsonPropertyName("numberOfServices")]
        public int NumberOfServices { get; set; }

        public string responsible { get; set; }
    }
}
