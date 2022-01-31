using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class BoardSpace : IBoardSpace
    {
        public string ID { get; private set; }
        public bool Occupied { get; set; }
        public char? Contents { get; set; }

        public BoardSpace()
        {
            ID = "A1";
            Occupied = false;
            Contents = null;
        }

        public BoardSpace(int row, char column)
        {
            ID = "" + column + row + "";
            Occupied = false;
            Contents = null;
        }
    }
}
