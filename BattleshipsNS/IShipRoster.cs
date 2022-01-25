using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IShipRoster
    {
        Ship[] Roster { get; set; }

        void SetShipRoster(Enum[] roster);
        bool CheckRosterSunk();
    }
}
