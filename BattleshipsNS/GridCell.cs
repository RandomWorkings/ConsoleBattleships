using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class GridCell : IGridCell
    {
        // Fields, Properties
        public string ID { get; private set; }
        public bool Occupied { get; set; }
        public char? Contents { get; set; }
        
        // Constructor Declaration of Class
        public GridCell(char column, int row)
        {
            ID = "" + column + row + "";
            Occupied = false;
            Contents = null;
        }

        // Methods, Events, Operators
    }
}
