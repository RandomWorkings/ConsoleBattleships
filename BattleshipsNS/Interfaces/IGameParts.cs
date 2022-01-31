using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public interface IGameParts
    {
        Ship[] Ships { get; }
        int SunkShipCount { get; }
        int CheckSunkShipsCount();
        bool CheckAllShipsSunk();

    }
}
