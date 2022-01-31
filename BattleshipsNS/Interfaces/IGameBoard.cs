using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IGameBoard
    {
        int BoardSize { get; }
        BoardSpace[,] PlayGrid { get; }

        BoardSpace GetTargetBoardSpace(string targetSpace);

    }
}
