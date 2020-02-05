using NUnit.Framework;
using TheWeddingShop.Direction;

namespace TheWeddingShop.Tests
{
    [TestFixture]
    public class AcceptanceCriteriaTest
    {
        [Test]
        public void Given_Rover_Start_At_1_2_North_When_Rover_Moves_Then_Rover_Will_Finish_At_1_3_North()
        {
            var landscape = new Landscape(5, 1, 2);
            var rover = new Rover(landscape, new North(landscape));

            rover.ExecuteCommands("LMLMLMLMM");

            Assert.That(rover.CoordinateX, Is.EqualTo(1));
            Assert.That(rover.CoordinateY, Is.EqualTo(3));
            Assert.That(rover.Direction.ToString(), Is.EqualTo("North"));
        }

        [Test]
        public void Given_Rover_Start_At_3_3_East_When_Rover_Moves_Then_Rover_Will_Finish_At_1_3_North()
        {
            var landscape = new Landscape(5, 3, 3);
            var rover = new Rover(landscape, new East(landscape));

            rover.ExecuteCommands("MMRMMRMRRM");

            Assert.That(rover.CoordinateX, Is.EqualTo(5));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
            Assert.That(rover.Direction.ToString(), Is.EqualTo("East"));
        }
    }
}
