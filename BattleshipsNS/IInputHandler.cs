using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IInputHandler
    {        
        bool ValidateInput(string userInput);
    }
}
