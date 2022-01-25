using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    class Ship : IShip
    {
        // Fields, Properties
        static int nextShipNumber=0;
        public string ID { get; set; }
        public int Length { get; set; }
        public int Orientation { get; set; }
        public GridCell StartLocation { get; set; }
        public GridCell[] SectionLocations { get; set; }
        public bool SunkFlag { get; set; }

        // Constructor Declaration of Class
        public Ship()
		{
            ID = "Ship-" + nextShipNumber++;
            Console.WriteLine(ID + " : READY");
        }

        // Methods, Events, Operators
        public void SetOrientation(int orientation)
        { }

        public void SetStartLocation(GridCell startLocation)
        { }
        
        public void UpdateSectionLocations()
        { }
        
        public void UpdateSunkFlag()
        { }
        
        public bool GetSunkFlag()
        { return false; }
    }
}
