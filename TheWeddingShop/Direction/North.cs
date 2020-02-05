using TheWeddingShop.Interfaces;

namespace TheWeddingShop.Direction
{
    public class North : IDirection
    {
        private readonly ILandscape _landscape;

        public North(ILandscape landscape)
        {
            _landscape = landscape;
        }

        public IDirection TurnLeft()
        {
            return new West(_landscape);
        }

        public IDirection TurnRight()
        {
            return new East(_landscape);
        }

        public void Move()
        {
            _landscape.MoveYForward();
        }

        public override string ToString()
        {
            return "North";
        }
    }
}
