using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public interface IOutputHandler
    {
        void GenerateMessages(int MessagesCode);
        void GenerateMessages(int MessagesCode, int SunkShipCount);

        void DisplayPlayGrid(GameBoard playGrid);
    }
}
