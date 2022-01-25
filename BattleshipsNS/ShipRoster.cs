using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    class ShipRoster : IShipRoster
    {
        // Fields, Properties
        public Ship[] Roster { get; set; }

        // Constructor Declaration of Class
        public ShipRoster()
        { }

        // Methods, Events, Operators
        public void SetShipRoster(Enum[] roster)
        { }

        public bool CheckRosterSunk()
        { return true; }

    }
}
