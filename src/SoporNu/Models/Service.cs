namespace SoporNu.Models
{
    public sealed record Service(ServiceType Type, int NumberOfServices, Action? LastAction, Action? NextAction, string? ExtraInformation, string? Responsible);
}
