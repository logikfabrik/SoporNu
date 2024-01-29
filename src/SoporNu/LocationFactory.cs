using System.Globalization;

namespace SoporNu
{
    internal static class LocationFactory
    {
        public static Location? Create(string? x, string? y)
        {
            static double? Parse(string? xy) => double.TryParse(xy, CultureInfo.GetCultureInfo("en-US"), out var locationXY) ? locationXY : null;

            var locationX = Parse(x);

            if (locationX is null)
            {
                return null;
            }

            var locationY = Parse(y);

            if (locationY is null)
            {
                return null;
            }

            return new Location(locationX.Value, locationY.Value);
        }
    }
}
