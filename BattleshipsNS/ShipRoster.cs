using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class ShipRoster : IShipRoster
    {
        // Fields, Properties
        public Ship[] Roster { get; private set; }

        // Constructor Declaration of Class
        public ShipRoster()
        { }

        // Methods, Events, Operators
        public bool CheckRosterSunk()
        { return true; }

    }
}
