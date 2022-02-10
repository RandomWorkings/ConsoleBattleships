namespace BattleshipsNS
{
    public class BattleshipsBoard : IBattleshipsBoard
    {
        public int BoardSize { get; private set; }
        public BattleshipsBoardSpace[,] PlayGrid { get; private set; }

        public BattleshipsBoard(int boardSize)
        {
            BoardSize = boardSize;
        }

        public void GeneratePlayGrid()
        {
            PlayGrid = new BattleshipsBoardSpace[BoardSize, BoardSize];

            // Set game board limits
            int rowCount = PlayGrid.GetLength(0);
            int columnCount = PlayGrid.GetLength(1);

            // Populate game board with board spaces
            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    PlayGrid[row, column] = new BattleshipsBoardSpace();
                }
            }
        }
    }
}