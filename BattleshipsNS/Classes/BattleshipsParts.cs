using System;
using System.Linq;

namespace BattleshipsNS
{
    public class BattleshipsParts : IBattleshipsParts
    {
        public IShip[] Ships { get; private set; }
        private int _ShipCount;
        public int ShipCount {  get { return _ShipCount; } set { OnShipCountChanged();}}
        public Messages ShipCountChange;

        public event EventHandler ShipCountChanged;

        protected virtual void OnShipCountChanged()
        {
            ShipCountChange = Messages.Sunk;
        }

        public BattleshipsParts()
        {
            ShipTypes[] ShipsList = { ShipTypes.Battleship, ShipTypes.Destroyer, ShipTypes.Destroyer};

            _ShipCount = ShipsList.Length;

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
            _ShipCount = shipsList.Length;
            Ships = new Ship[ShipCount];

            // Populate Ships Array with Ships
            for (int i = 0; i < ShipCount; i++)
            {
                ShipTypes shipType = shipsList[i];
                Ships[i] = new Ship(shipType);
            }
        }

        public Messages UpdateShipCount()
        {
            Messages ShipCountChange = 0;
            _ShipCount = Ships.Length;

            foreach (IShip ship in Ships)
            {
                UpdateShipSunk(ship);
                if(ship.Sunk)
                {
                    ShipCount--;
                }
            }
            return ShipCountChange;
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