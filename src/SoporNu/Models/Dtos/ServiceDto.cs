using System.Text.Json.Serialization;

namespace SoporNu.Models.Dtos
{
    internal sealed class ServiceDto
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

        [JsonPropertyName("numberOfServices")]
        public int NumberOfServices { get; set; }

        [JsonPropertyName("lastActionAltText")]
        public string? LastActionAltText { get; set; }

        [JsonPropertyName("lastAction")]
        public DateTime? LastActionDateUtc { get; set; }

        [JsonPropertyName("nextActionAltText")]
        public string? NextActionAltText { get; set; }

        [JsonPropertyName("nextAction")]
        public DateTime? NextActionDateUtc { get; set; }

        [JsonPropertyName("extraInfo")]
        public string? ExtraInformation { get; set; }

        [JsonPropertyName("responsible")]
        public string? Responsible { get; set; }
    }
}
