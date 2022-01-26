using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IGridCell
    {
        string ID { get; }
        bool Occupied { get; set; }
        char? Contents { get; set; }
    }
}
