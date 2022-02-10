namespace BattleshipsNS
{
    public class GameParts : IGameParts
    {
        public IShip[] Ships { get; private set; }
        public int ShipCount { get; private set; } = 0;

        public GameParts()
        {
            ShipTypes[] ShipsList = { ShipTypes.Battleship, ShipTypes.Destroyer, ShipTypes.Destroyer };

            ShipCount = ShipsList.Length;

            Ships = new Ship[ShipCount];

            // Populate Ships Array with Ships
            for (int i = 0; i < ShipCount; i++)
            {
                ShipTypes shipType = ShipsList[i];
                Ships[i] = new Ship(shipType);
            }
        }

        public GameParts(ShipTypes[] shipsList)
        {
            ShipCount = shipsList.Length;
            Ships = new Ship[ShipCount];

            // Populate Ships Array with Ships
            for (int i = 0; i < ShipCount; i++)
            {
                ShipTypes shipType = shipsList[i];
                Ships[i] = new Ship(shipType);
            }
        }

        public int UpdateShipCount()
        {
            int returnValue = 0;
            ShipCount = Ships.Length;

            foreach (Ship ship in Ships)
            {
                ship.UpdateSunk();
                if(ship.Sunk)
                {
                    ShipCount--;
                    returnValue = (int)Messages.Sunk;
                }
            }
            return returnValue;
        }
    }
}