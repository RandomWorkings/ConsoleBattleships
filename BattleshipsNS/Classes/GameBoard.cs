namespace BattleshipsNS
{
    public class GameBoard : IGameBoard
    {
        public int BoardSize { get; private set; } = 10;
        public IBoardSpace[,] PlayGrid { get; private set; }

        public GameBoard()
        {
            PlayGrid = new IBoardSpace[BoardSize, BoardSize];

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

        public GameBoard(int boardSize)
        {
            BoardSize = boardSize;
            PlayGrid = new IBoardSpace[BoardSize, BoardSize];

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