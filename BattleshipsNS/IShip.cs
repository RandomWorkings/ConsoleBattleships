using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IShip
    {
        /*
         * A method to check if all ships are sunk
        */
        bool HasShipBeenSunk { get; }
    }
}
