namespace SoporNu.Models
{
    public record Avs(
        AvsId Id,
        ExternalAvsId ExternalId,

        AvsName Name,

        Municipality Municipality,

        string? StreetAddress,

        string? PropertyName,

        Location? Location,

        string? ExtraInformation);
}