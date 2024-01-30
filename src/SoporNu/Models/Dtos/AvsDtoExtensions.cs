namespace SoporNu.Models.Dtos
{
    internal static class AvsDtoExtensions
    {
        public static string? GetPrimaryName(this AvsDto avs) => Get(avs.PrimaryName);

        public static string? GetSecondaryName(this AvsDto avs) => Get(avs.SecondaryName);

        public static string? GetStreetAddress(this AvsDto avs) => Get(avs.StreetAddress);

        public static string? GetPropertyNumber(this AvsDto avs) => Get(avs.PropertyNumber);

        public static string? GetExtraInformation(this AvsDto avs) => Get(avs.ExtraInformation);

        private static string? Get(string? s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();
    }
}
