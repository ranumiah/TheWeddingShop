﻿using TheWeddingShop.Interfaces;

namespace TheWeddingShop
{
    public class Landscape : ILandscape
    {
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }
        private readonly int _gridSize;

        public Landscape(int gridSize, int xAxis = 0, int yAxis = 0)
        {
            CoordinateX = xAxis;
            CoordinateY = yAxis;
            _gridSize = gridSize;
        }

        public void MoveXForward()
        {
            if (CoordinateX < _gridSize)
                CoordinateX++;
        }

        public void MoveXBackward()
        {
            if (CoordinateX > 0)
                CoordinateX--;
        }

        public void MoveYForward()
        {
            if (CoordinateY < _gridSize)
                CoordinateY++;
        }

        public void MoveYBackward()
        {
            if (CoordinateY > 0)
                CoordinateY--;
        }
    }
}