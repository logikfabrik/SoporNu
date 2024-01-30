using SoporNu.Models.Dtos;

namespace SoporNu.Models
{
    internal static class AvsFactory
    {
        public static Avs Create(AvsDto avs)
        {
            var id = new AvsId(Guid.Parse(avs.Id));

            var externalId = new ExternalAvsId(avs.ExternalId);

            var name = new AvsName(avs.GetPrimaryName(), avs.GetSecondaryName());

            var municipality = MunicipalityFactory.Create(avs.MunicipalityCode);

            var location = LocationFactory.Create(avs.X, avs.Y);

            return new Avs(id, externalId, name, municipality, avs.GetStreetAddress(), avs.GetPropertyNumber(), location, avs.GetExtraInformation());
        }
    }
}
