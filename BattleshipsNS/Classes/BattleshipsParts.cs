using System.Linq;

namespace BattleshipsNS
{
    public class BattleshipsParts : IBattleshipsParts
    {
        public IShip[] Ships { get; private set; }
        public int ShipCount { get; private set; } = 0;

        public BattleshipsParts()
        {
            ShipTypes[] ShipsList = { ShipTypes.Battleship, ShipTypes.Destroyer, ShipTypes.Destroyer};

            ShipCount = ShipsList.Length;

            Ships = new Ship[ShipCount];

            // Populate Ships Array with Ships
            for (int i = 0; i < ShipCount; i++)
            {
                ShipTypes shipType = ShipsList[i];
                Ships[i] = new Ship(shipType);
            }
        }

        public BattleshipsParts(ShipTypes[] shipsList)
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

            foreach (IShip ship in Ships)
            {
                UpdateShipSunk(ship);
                if(ship.Sunk)
                {
                    ShipCount--;
                    returnValue = (int)Messages.Sunk;
                }
            }
            return returnValue;
        }

        private void UpdateShipSunk(IShip ship)
        {
            int sunkSections = 0;

            if (!ship.Sunk)
            {
                sunkSections = ship.Sections.Count(section => section.Contents == 'x'); // x indicates a targeted and occupied location.

                if (sunkSections == ship.Length)
                {
                    ship.Sunk = true;
                }
            }
        }
    }
}