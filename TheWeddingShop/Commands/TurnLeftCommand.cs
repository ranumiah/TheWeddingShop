using TheWeddingShop.Interfaces;

namespace TheWeddingShop.Commands
{
    public class TurnLeftCommand : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnLeft();
        }
    }
}