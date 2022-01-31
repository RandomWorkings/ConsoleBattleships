using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public interface IBattleshipsSetup
    {
        GameParts GameParts { get; }
        GameBoard GameBoard { get; }
    }
}
