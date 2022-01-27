using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IGameBoard
    {
        int Size { get; }
        BoardSpace[,] PlayGrid { get; }

        BoardSpace GetTargetGridCell(string gridCell);

    }
}
