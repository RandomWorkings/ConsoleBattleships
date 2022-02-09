﻿namespace BattleshipsNS
{
    public class GameBoard : IBattleshipsGameBoard
    {
        public int BoardSize { get; private set; } = 10;
        public BoardSpace[,] PlayGrid { get; private set; }
        public GameBoard(int boardSize)
        {
            BoardSize = boardSize;
            PlayGrid = new BoardSpace[BoardSize, BoardSize];

            // Set game board limits
            int rowCount = PlayGrid.GetLength(0);
            int columnCount = PlayGrid.GetLength(1);

            // Populate game board with board spaces
            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    PlayGrid[row, column] = new BoardSpace();
                }
            }
        }
    }
}