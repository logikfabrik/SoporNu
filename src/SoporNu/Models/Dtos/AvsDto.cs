using System.Text.Json.Serialization;

namespace SoporNu.Models.Dtos
{
    internal sealed class AvsDto
    {
        [JsonPropertyName("id")]
        public required string Id { get; set; }

        [JsonPropertyName("accountId")]
        public string? AccountId { get; set; }

        [JsonPropertyName("externalAvsId")]
        public required string ExternalId { get; set; }

        [JsonPropertyName("name")]
        public string? PrimaryName { get; set; }

        [JsonPropertyName("secondaryName")]
        public string? SecondaryName { get; set; }

        [JsonPropertyName("propertyNumber")]
        public string? PropertyNumber { get; set; }

        [JsonPropertyName("municipalityCode")]
        public required string MunicipalityCode { get; set; }

        [JsonPropertyName("streetAddress")]
        public string? StreetAddress { get; set; }

        [JsonPropertyName("long")]
        public string? X { get; set; }

        [JsonPropertyName("lat")]
        public string? Y { get; set; }

        [JsonPropertyName("extraInfo")]
        public string? ExtraInformation { get; set; }

        [JsonPropertyName("services")]
        public ServiceDto[]? Services { get; set; }
    }
}