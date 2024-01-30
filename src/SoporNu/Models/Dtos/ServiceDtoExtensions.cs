namespace SoporNu.Models.Dtos
{
    internal static class ServiceDtoExtensions
    {
        public static string? GetLastActionAltText(this ServiceDto service) => Get(service.LastActionAltText);

        public static string? GetNextActionAltText(this ServiceDto service) => Get(service.NextActionAltText);

        public static string? GetExtraInformation(this ServiceDto service) => Get(service.ExtraInformation);

        public static string? GetResponsible(this ServiceDto service) => Get(service.Responsible);

        private static string? Get(string? s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();
    }
}
