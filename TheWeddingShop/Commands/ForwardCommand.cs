using TheWeddingShop.Interfaces;

namespace TheWeddingShop.Commands
{
    public class ForwardCommand : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.MoveForward();
        }
    }
}
