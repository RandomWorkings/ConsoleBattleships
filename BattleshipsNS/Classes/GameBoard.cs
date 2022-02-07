namespace BattleshipsNS
{
    public class GameBoard : IGameBoard
    {
        public int BoardSize { get; private set; } = 10;
        public BoardSpace[,] PlayGrid { get; private set; }
        public GameBoard(int boardSize)
        {
            // Set grid size
            BoardSize = boardSize;
            
            // Create grid
            PlayGrid = new BoardSpace[BoardSize, BoardSize];

            // Fill grid with board spaces 
            int rowCount = PlayGrid.GetLength(0);
            int columnCount = PlayGrid.GetLength(1);

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