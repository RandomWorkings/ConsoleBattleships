using ProgramNS;

namespace BattleshipsNS
{
    public class BattleshipsShips : IBattleshipsShips
    {
        public BattleshipsShip[] Ships { get; private set; }
        public int ShipCount { get; private set; } = 0;

        public BattleshipsShips(ShipTypes[] shipsList)
        {
            ShipCount = shipsList.Length;
            Ships = new BattleshipsShip[ShipCount];

            // Populate Ships Array with Ships
            for (int i = 0; i < ShipCount; i++)
            {
                ShipTypes shipType = shipsList[i];
                Ships[i] = new BattleshipsShip(shipType);
            }
        }

        public int UpdateShipCount()
        {
            int returnValue = 0;
            ShipCount = Ships.Length;

            foreach (BattleshipsShip ship in Ships)
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