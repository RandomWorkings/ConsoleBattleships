namespace BattleshipsNS
{
    public class BattleshipsSetup : IBattleshipsSetup
    {
        public GameParts GameParts { get; private set; }
        public GameBoard GameBoard { get; private set; }
        private int BoardSize;
        private ShipTypes[] ShipsList;

        public BattleshipsSetup()
        {
            // Program Default settings
            BoardSize = 10;
            ShipTypes[] ShipsList = { ShipTypes.Battleship, ShipTypes.Destroyer, ShipTypes.Destroyer };

            // Create Game Components
            GameParts = new GameParts(ShipsList);
            GameBoard = new GameBoard(BoardSize);

            // Setup Game Components
            foreach (Ship ship in GameParts.Ships)
            {
                ship.PlaceShip(GameBoard);
            }
        }

        public BattleshipsSetup(int boardSize, ShipTypes[] shipsList)
        {
            BoardSize = boardSize;
            ShipsList = shipsList;

            // Create Game Components
            GameParts = new GameParts(ShipsList);
            GameBoard = new GameBoard(BoardSize);

            // Setup Game Components
            foreach (Ship ship in GameParts.Ships)
            {
                ship.PlaceShip(GameBoard);
            }
        }
    }
}