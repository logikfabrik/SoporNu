using SoporNu.Models.Dtos;

namespace SoporNu.Models
{
    internal static class AvsFactory
    {
        public static Avs Create(AvsDto avs)
        {
            var id = new AvsId(Guid.Parse(avs.Id));

            var externalId = new ExternalAvsId(avs.ExternalId);

            var municipality = MunicipalityFactory.Create(avs.MunicipalityCode);

            static string? GetName(string? name)
            {
                name = name?.Trim();

                if (name is null || name == string.Empty)
                {
                    return null;
                }

                return name;
            }

            var location = LocationFactory.Create(avs.X, avs.Y);

            return new Avs(id, externalId, municipality, GetName(avs.PrimaryName), GetName(avs.SecondaryName), location);
        }
    }
}
