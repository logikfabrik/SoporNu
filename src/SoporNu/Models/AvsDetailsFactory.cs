using SoporNu.Models.Dtos;

namespace SoporNu.Models
{
    internal static class AvsDetailsFactory
    {
        public static AvsDetails Create(AvsDto avs)
        {
            var original = AvsFactory.Create(avs);

            var services = avs.Services?.Select(ServiceFactory.Create)?.ToArray() ?? [];

            return new AvsDetails(original, services);
        }
    }
}
