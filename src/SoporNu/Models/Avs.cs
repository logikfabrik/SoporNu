namespace SoporNu.Models
{
    public sealed record Avs(
        AvsId Id,
        ExternalAvsId ExternalId,
        Municipality Municipality,
        string? PrimaryName,
        string? SecondaryName,
        Location? Location);
}