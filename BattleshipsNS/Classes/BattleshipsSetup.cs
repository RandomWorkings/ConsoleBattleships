namespace BattleshipsNS
{
    class BattleshipsSetup : IBattleshipsSetup
    {
        public GameParts GameParts { get; private set; }
        public GameBoard GameBoard { get; private set; }

        public BattleshipsSetup()
        {
            // Program Default settings
            int boardSize = 10;
            ShipTypes[] shipsList = { ShipTypes.Battleship, ShipTypes.Destroyer, ShipTypes.Destroyer};

            // Create Game Components
            GameParts = new GameParts(shipsList);
            GameBoard = new GameBoard(boardSize);

            // Setup Game Components
            foreach (Ship ship in GameParts.Ships)
            {
                ship.PlaceShip(GameBoard);
            }
        }
    }
}