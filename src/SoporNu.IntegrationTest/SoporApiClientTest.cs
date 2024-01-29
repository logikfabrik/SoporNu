namespace SoporNu.IntegrationTest
{
    public class SoporApiClientTest
    {
        public class GetAllAvs
        {
            [Fact]
            public async Task Should_Return_All_Avs()
            {
                var httpClient = new HttpClient
                {
                    BaseAddress = new Uri("https://avfallshubben.avfallsverige.se/umbraco/Api/SoporApi/")
                };

                var sut = new SoporApiClient(httpClient);

                var avs = await sut.GetAllAvs();

                var d = 0;
            }
        }

    }
}