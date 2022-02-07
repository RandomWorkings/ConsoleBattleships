namespace BattleshipsNS
{
    public enum ShipTypes
    {
        Battleship = 4,
        Destroyer = 3
    };

    class BattleshipsSetup : IBattleshipsSetup
    {
        public GameParts GameParts { get; private set; }
        public GameBoard GameBoard { get; private set; }

        public BattleshipsSetup()
        {
            // Program Default settings
            int boardSize = 10;
            ShipTypes[] shipsList = { ShipTypes.Battleship, ShipTypes.Destroyer, ShipTypes.Destroyer };

            GameParts = new GameParts(shipsList);
            GameBoard = new GameBoard(boardSize);

            foreach (Ship ship in GameParts.Ships)
            {
                ship.PlaceShip(GameBoard);
            }
        }
    }
}