using NUnit.Framework;
using TheWeddingShop.Direction;
using TheWeddingShop.Interfaces;

namespace TheWeddingShop.Tests
{
    [TestFixture]
    public class RoverTests
    {
        private ILandscape _landscape;
        private Rover _rover;

        [SetUp]
        public void Setup()
        {
            _landscape = new Landscape(5);
            _rover = new Rover(_landscape, new North(_landscape));
        }

        [Test]
        public void When_Rover_Is_Created_Start_At_North()
        {
            Assert.That(_rover.Direction, Is.TypeOf<North>());
        }

        [Test]
        public void When_Rover_Is_Created_And_Turn_Left_The_Direction_Is_West()
        {
            _rover.TurnLeft();
            Assert.That(_rover.Direction, Is.TypeOf<West>());
        }

        [Test]
        public void When_Rover_Is_Created_And_Turn_Right_The_Direction_Is_East()
        {
            _rover.TurnRight();
            Assert.That(_rover.Direction, Is.TypeOf<East>());
        }
        
        [Test]
        public void When_Rover_Is_Created_Is_Facing_North_And_Move_Rover_Will_Be_At_Coordinates_0_1()
        {
            _rover.MoveForward();
            Assert.That(_rover.CoordinateX, Is.EqualTo(0));
            Assert.That(_rover.CoordinateY, Is.EqualTo(1));
        }

        [Test]
        public void When_The_Rover_Is_Created_Turn_Right_And_Move_Rover_Will_Be_At_Coordinates_1_0()
        {
            _rover.TurnRight();
            _rover.MoveForward();
            Assert.That(_rover.CoordinateX, Is.EqualTo(1));
            Assert.That(_rover.CoordinateY, Is.EqualTo(0));            
        }

        [Test]
        public void When_The_Rover_Is_Created_And_Move_So_That_Facing_South_And_Move_Coordinates_Will_Be_0_1()
        {
            _rover.MoveForward();
            _rover.MoveForward();
            _rover.TurnRight();
            _rover.TurnRight();

            Assert.That(_rover.Direction, Is.TypeOf<South>());
            _rover.MoveForward();
            Assert.That(_rover.CoordinateX, Is.EqualTo(0));
            Assert.That(_rover.CoordinateY, Is.EqualTo(1));
        }

        [Test]
        public void When_The_Rover_Is_Created_And_Move_So_That_Facing_West_And_Move_Coordinates_Will_Be_1_0()
        {
            _rover.TurnRight();
            _rover.MoveForward();
            _rover.MoveForward();
            _rover.TurnRight();
            _rover.TurnRight();

            Assert.That(_rover.Direction, Is.TypeOf<West>());
            _rover.MoveForward();
            Assert.That(_rover.CoordinateX, Is.EqualTo(1));
            Assert.That(_rover.CoordinateY, Is.EqualTo(0));
        }

        [Test]
        public void When_Start_Move_Turn_Turn_Move_Back_To_Home_Coordinates()
        {
            _rover.MoveForward();
            _rover.TurnLeft();
            _rover.TurnLeft();
            _rover.MoveForward();

            Assert.That(_rover.CoordinateX, Is.EqualTo(0));
            Assert.That(_rover.CoordinateY, Is.EqualTo(0));
        }
    }
}
