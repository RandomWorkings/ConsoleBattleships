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
        public ShipRoster(string[] roster)
        {
            Roster = new Ship[roster.Length];

            for(int i = 0; i < roster.Length; i++)
            {
                Roster[i] = new Ship(roster[i]);
            }
        }

        // Methods, Events, Operators
        public bool CheckRosterSunk()
        { return true; }

    }
}
