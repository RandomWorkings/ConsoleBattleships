using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    
    class Grid : IGrid
    {
        // Fields, Properties
        public int Size { get; set; }
        public GridCell[,] PlayGrid { get; set; }

        // Constructor Declaration of Class
        public Grid(int gridSize)
        { }

        // Methods, Events, Operators
        public void DisplayPlayGrid()
        { }
        public GridCell GetTargetGridCell(string gridCell)
        { return new GridCell(); }
    }
}
