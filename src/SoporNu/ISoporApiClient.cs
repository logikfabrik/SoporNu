namespace SoporNu
{
    public interface ISoporApiClient
    {
        Task<Avs[]> GetAllAvs(CancellationToken cancellationToken = default);
    }
}
