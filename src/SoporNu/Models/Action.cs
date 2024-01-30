namespace SoporNu.Models
{
    /// <summary>
    ///   A service action.
    /// </summary>
    /// <param name="AltText">Alt. text description of the service action taken, or to be.</param>
    /// <param name="DateUtc">When the service action was taken, or will be.</param>
    public sealed record Action(string? AltText, DateOnly? DateUtc);
}
