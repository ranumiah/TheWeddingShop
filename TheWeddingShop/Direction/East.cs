using TheWeddingShop.Interfaces;

namespace TheWeddingShop.Direction
{
    public class East : IDirection
    {
        private readonly ILandscape _landscape;

        public East(ILandscape landscape)
        {
            _landscape = landscape;
        }

        public IDirection TurnLeft()
        {
            return new North(_landscape);
        }

        public IDirection TurnRight()
        {
            return new South(_landscape);
        }

        public void Move()
        {
            _landscape.MoveXForward();
        }

        public override string ToString()
        {
            return "East";
        }
    }
}