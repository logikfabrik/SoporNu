using SoporNu.Models;

namespace SoporNu.Test.Models
{
    public sealed class MunicipalityFactoryTest
    {
        public sealed class Create
        {
            [Fact]
            public void Should_ReturnAMunicipalityWithName()
            {
                var municipality = MunicipalityFactory.Create("1489");

                municipality.Name.Should().NotBeNull();
            }

            [Fact]
            public void Should_ReturnAMunicipalityWithoutName_When_TheMunicipalityDoesNotExist()
            {
                var municipality = MunicipalityFactory.Create("0000");

                municipality.Name.Should().BeNull();
            }
        }
    }
}
