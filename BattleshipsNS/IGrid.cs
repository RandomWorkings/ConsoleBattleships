using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IGrid
    {
        int Size { get; }
        GridCell[,] PlayGrid { get; set; }

        GridCell GetTargetGridCell(string gridCell);

    }
}
