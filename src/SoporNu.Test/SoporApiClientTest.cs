using System.Net;
using System.Net.Mime;

using RichardSzalay.MockHttp;

using SoporNu.Test.Testing;

namespace SoporNu.Test
{
    public sealed class SoporApiClientTest
    {
        private static ISoporApiClient CreateClient(MockHttpMessageHandler handler)
        {
            return new SoporApiClient(handler.ToHttpClient());
        }

        public sealed class GetAllAvs
        {
            [Theory]
            [FileTextData(@".testdata/GetAllAvs_Should_ReturnTheAvs.json")]
            public async Task Should_ReturnTheAvs(string responseJson)
            {
                var handlerStub = new MockHttpMessageHandler();

                handlerStub.When(HttpMethod.Get, "https://avfallshubben.avfallsverige.se/umbraco/Api/SoporApi/GetAllAvs").Respond(MediaTypeNames.Application.Json, responseJson);

                var sut = CreateClient(handlerStub);

                var avs = await sut.GetAllAvs();

                avs.Should().NotBeEmpty();
            }

            [Theory]
            [FileTextData(@".testdata/GetAllAvs_Should_ReturnNoAvs_When_NoneExist.json")]
            public async Task Should_ReturnNoAvs_When_NoneExist(string responseJson)
            {
                var handlerStub = new MockHttpMessageHandler();

                handlerStub.When(HttpMethod.Get, "https://avfallshubben.avfallsverige.se/umbraco/Api/SoporApi/GetAllAvs").Respond(MediaTypeNames.Application.Json, responseJson);

                var sut = CreateClient(handlerStub);

                var avs = await sut.GetAllAvs();

                avs.Should().BeEmpty();
            }
        }

        public sealed class GetAvs
        {
            [Theory]
            [FileTextData(@".testdata/GetAvs_Should_ReturnTheAvs.json")]
            public async Task Should_ReturnTheAvs(string responseJson)
            {
                var handlerStub = new MockHttpMessageHandler();

                handlerStub.When(HttpMethod.Get, "https://avfallshubben.avfallsverige.se/umbraco/Api/SoporApi/GetAvs?municipalityCode=1489&externalAvsId=6990").Respond(MediaTypeNames.Application.Json, responseJson);

                var sut = CreateClient(handlerStub);

                var avs = await sut.GetAvs(new MunicipalityCode("1489"), new ExternalAvsId("6990"));

                avs.Should().NotBeNull();
            }

            [Theory]
            [FileTextData(@".testdata/GetAvs_Should_Throw_When_TheAvsDoesNotExist.json")]
            public async Task Should_Throw_When_TheAvsDoesNotExist(string responseJson)
            {
                var handlerStub = new MockHttpMessageHandler();

                handlerStub.When(HttpMethod.Get, "https://avfallshubben.avfallsverige.se/umbraco/Api/SoporApi/GetAvs?municipalityCode=0000&externalAvsId=00000").Respond(MediaTypeNames.Application.Json, responseJson);

                var sut = CreateClient(handlerStub);

                var act = FluentActions.Awaiting(async () => await sut.GetAvs(new MunicipalityCode("0000"), new ExternalAvsId("00000")));

                (await act.Should().ThrowAsync<HttpRequestException>()).And.StatusCode.Should().Be(HttpStatusCode.NotFound);
            }
        }
    }
}
