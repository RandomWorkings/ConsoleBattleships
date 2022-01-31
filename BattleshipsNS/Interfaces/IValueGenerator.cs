
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public interface IValueGenerator
    {
        int GetRandomOrientation();
        (int, int) GetRandomLocation(int shipOrientation, int shipLength, int boardSize);
    }
}
