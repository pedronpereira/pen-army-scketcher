using System.IO;
using Xunit;

namespace PeNArmyScketcher.AgeOfSigmar.Tests.Factories
{
    public class StormcastEternalsFactoryTests
    {
        [Fact]
        public void GetWarscrolls_DeserializesSuccessfuly()
        {
            var factory = new StormcastEternalsFactory();
            var dir = Directory.GetCurrentDirectory();
            var warscrollsPath = "resources/warscrolls/stormcast-warscrolls-settings-20190517125430.json";
            var warscrolls = factory.GetWarsrolls(warscrollsPath);

            Assert.NotEmpty(warscrolls);
        }
    }
}
