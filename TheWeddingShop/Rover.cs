using TheWeddingShop.Commands;
using TheWeddingShop.Interfaces;

namespace TheWeddingShop
{
    public class Rover : IRover
    {
        private readonly ILandscape _landscape;

        public IDirection Direction { get; private set; }

        public Rover(ILandscape landscape, IDirection direction)
        {
            _landscape = landscape;
            Direction = direction;
        }

        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }

        public void TurnRight()
        {
            Direction = Direction.TurnRight();
        }

        public void MoveForward()
        {
            Direction.Move();
        }

        public int CoordinateX => _landscape.CoordinateX;

        public int CoordinateY => _landscape.CoordinateY;

        public override string ToString()
        {
            return $"X : {CoordinateX}, Y : {CoordinateY}, Direction : {Direction}";
        }

        public void ExecuteCommands(string commandString)
        {
            var commands = AvailableCommands.List;
            var commandParser = new CommandParser(commands);

            for (var index = 0; index < commandString.Length; index++)
            {
                var command = commandString[index].ToString();
                var commandToExecute = commandParser.ParseCommand(command);
                commandToExecute.Execute(this);
            }
        }
    }
}