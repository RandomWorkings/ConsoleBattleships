using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IGameParts
    {
        Ship[] Ships { get; }

        bool CheckAllShipsSunk();
    }
}
