using System.Net;

namespace SoporNu.IntegrationTest
{
    public sealed class SoporApiClientTest
    {
        public sealed class GetAllAvs
        {
            [Fact]
            public async Task Should_ReturnTheAvs()
            {
                var sut = new SoporApiClient();

                var avs = await sut.GetAllAvs();

                avs.Should().NotBeEmpty();
            }
        }

        public sealed class GetAvs
        {
            [Fact]
            public async Task Should_ReturnTheAvs()
            {
                var sut = new SoporApiClient();

                var avs = await sut.GetAvs(new MunicipalityCode("0183"), new ExternalAvsId("15377"));

                avs.Should().NotBeNull();
            }

            [Fact]
            public async Task Should_Throw_When_TheAvsDoesNotExist()
            {
                var sut = new SoporApiClient();

                var act = FluentActions.Awaiting(async () => await sut.GetAvs(new MunicipalityCode("0000"), new ExternalAvsId("00000")));

                (await act.Should().ThrowAsync<HttpRequestException>()).And.StatusCode.Should().Be(HttpStatusCode.NotFound);
            }
        }
    }
}