namespace TheWeddingShop.Interfaces
{
    public interface ILandscape
    {
        int CoordinateX { get; }
        int CoordinateY { get; }
        void MoveXForward();
        void MoveXBackward();
        void MoveYForward();
        void MoveYBackward();
    }
}
