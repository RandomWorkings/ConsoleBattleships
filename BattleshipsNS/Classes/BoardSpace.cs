using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class BoardSpace : IBoardSpace
    {
        public bool Occupied { get; set; } = false;
        public char? Contents { get; set; } = null;

    }
}
