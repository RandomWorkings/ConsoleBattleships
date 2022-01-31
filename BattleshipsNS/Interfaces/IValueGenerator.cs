
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IValueGenerator
    {
        int GetRandomOrientation();
        (int, int) GetRandomLocation(int refOrientation, int refLength, int refSize);
    }
}
