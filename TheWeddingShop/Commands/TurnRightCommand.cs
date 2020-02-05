using TheWeddingShop.Interfaces;

namespace TheWeddingShop.Commands
{
    public class TurnRightCommand : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnRight();
        }
    }
}