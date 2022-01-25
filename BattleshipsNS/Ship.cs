using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class Ship : IShip
    {
        // Fields, Properties
        static int NextShipNumber = 1;
        public string ID { get; private set; }
        public int Length { get; private set; }
        public int Orientation { get; set; }
        public GridCell StartLocation { get; set; }
        public GridCell[] SectionLocations { get; private set; }
        public bool SunkFlag { get; private set; }

        // Constructor Declaration of Class
        public Ship()
		{
            ID = "Ship-" + NextShipNumber++;
        }

        // Methods, Events, Operators

        public void UpdateSectionLocations()
        { }
        
        public void UpdateSunkFlag()
        { }
        
    }
}
