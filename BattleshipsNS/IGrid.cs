using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IGrid
    {
        int Size { get; set; }
        GridCell[,] PlayGrid { get; set; }

        void PlaceShipRoster();
        void DisplayPlayGrid();
        GridCell AccessPlayGridCell(string gridCell);

    }
}
