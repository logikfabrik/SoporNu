using SoporNu.Models;

namespace SoporNu
{
    public interface ISoporApiClient
    {
        Task<Avs[]> GetAllAvs(CancellationToken cancellationToken = default);

        Task<Avs[]> GetAvsNearby(Location location, int maxDistanceM, CancellationToken cancellationToken = default);

        Task<AvsDetails?> GetAvs(MunicipalityCode municipalityCode, ExternalAvsId externalId, CancellationToken cancellationToken = default);
    }
}
