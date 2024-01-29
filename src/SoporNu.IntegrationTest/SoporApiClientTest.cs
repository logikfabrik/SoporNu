namespace SoporNu.IntegrationTest
{
    public class SoporApiClientTest
    {
        public class GetAllAvs
        {
            [Fact]
            public async Task Should_Return_Avs()
            {
                var httpClient = new HttpClient
                {
                    BaseAddress = new Uri("https://avfallshubben.avfallsverige.se/umbraco/Api/SoporApi/")
                };

                var sut = new SoporApiClient(httpClient);

                var avs = await sut.GetAllAvs();

                avs.Should().NotBeEmpty();
            }
        }

        public class GetAvs
        {
            [Fact]
            public async Task Should_Return_Avs()
            {
                var httpClient = new HttpClient
                {
                    BaseAddress = new Uri("https://avfallshubben.avfallsverige.se/umbraco/Api/SoporApi/")
                };

                var sut = new SoporApiClient(httpClient);

                var avs = await sut.GetAvs(new MunicipalityCode("0183"), new ExternalAvsId("15377"));

                avs.Should().NotBeNull();
            }

            [Fact]
            public async Task Should_Not_Return_Avs()
            {
                var httpClient = new HttpClient
                {
                    BaseAddress = new Uri("https://avfallshubben.avfallsverige.se/umbraco/Api/SoporApi/")
                };

                var sut = new SoporApiClient(httpClient);

                var avs = await sut.GetAvs(new MunicipalityCode("0000"), new ExternalAvsId("00000"));

                avs.Should().BeNull();
            }
        }
    }
}