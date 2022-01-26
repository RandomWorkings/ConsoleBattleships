using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public enum ShipTypes
    {
        Battleship = 4,
        Destroyer = 3
    };

    public class Ship : IShip
    {
        // Fields, Properties
        public string ID { get; private set; }
        public int Length { get; private set; }
        public int Orientation { get; set; }
        public GridCell StartLocation { get; set; }
        public GridCell[] SectionLocations { get; private set; }
        public bool SunkFlag { get; private set; }

        // Constructor Declaration of Class
        public Ship(string ship, int shipCount)
		{
            ID = ship + " - s" + shipCount;

            ShipTypes shipType = (ShipTypes)Enum.Parse(typeof(ShipTypes), ship);

            Length = (int)shipType;

            SunkFlag = false;
        }

        // Methods, Events, Operators

        public void UpdateSectionLocations()
        { }
        
        public void UpdateSunkFlag()
        { }
        
    }
}
