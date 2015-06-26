using NUnit.Framework;

namespace MusicSalesTests
{
    [TestFixture]
    public class MusicSalesTest
    {
        [Test]
        public void Tests_are_running()
        {
            const string betterSystems = "EmergentDesign";
            Assert.That("EmergentDesign", Is.EqualTo(betterSystems));
        }
    }
}
