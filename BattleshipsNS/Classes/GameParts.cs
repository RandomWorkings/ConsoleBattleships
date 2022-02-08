namespace BattleshipsNS
{
    public class GameParts : IGameParts
    {
        public Ship[] Ships { get; private set; }
        public int ShipCount { get; private set; } = 0;

        public GameParts(ShipTypes[] shipsList)
        {
            ShipCount = shipsList.Length;

            Ships = new Ship[ShipCount];

            // Fill Ship Array with Ships
            for (int i = 0; i < ShipCount; i++)
            {
                ShipTypes shipType = shipsList[i];
                Ships[i] = new Ship(shipType);
            }
        }

        public void UpdateShipCount()
        {
            ShipCount = Ships.Length;

            foreach (Ship ship in Ships)
            {
                ship.UpdateSunk();
                if (ship.Sunk)
                {
                    ShipCount--;
                }
            }
        }
    }
}