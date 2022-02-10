namespace BattleshipsNS
{
    public class GameComponents : IBattleshipComponents
    {
        public Ship[] Ships { get; private set; }
        public int ShipCount { get; private set; } = 0;

        public GameComponents(ShipTypes[] shipsList)
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