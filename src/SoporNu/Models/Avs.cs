﻿namespace SoporNu.Models
{
    public record Avs(
        AvsId Id,
        ExternalAvsId ExternalId,
        Municipality Municipality,
        string? PrimaryName,
        string? SecondaryName,
        Location? Location);
}