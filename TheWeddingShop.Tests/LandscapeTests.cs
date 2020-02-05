using NUnit.Framework;

namespace TheWeddingShop.Tests
{
    [TestFixture]
    public class LandscapeTests
    {
        [Test]
        public void When_Create_The_Landscape_Then_The_Default_Rover_Position_Will_Be_0_0()
        {
            var landscape = new Landscape(5);

            Assert.That(landscape.CoordinateX, Is.EqualTo(0));
            Assert.That(landscape.CoordinateY, Is.EqualTo(0));
        }
    }
}
