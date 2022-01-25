using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    class GridCell : IGridCell
    {
        // Fields, Properties
        public string ID { get; set; }
        public char Contents { get; set; }

        
        // Constructor Declaration of Class
        public GridCell()
        { }

        // Methods, Events, Operators
        public void SetCellContents(char contents)
        { }
        public char GetCellContents()
        { return 'a'; }
    }
}
