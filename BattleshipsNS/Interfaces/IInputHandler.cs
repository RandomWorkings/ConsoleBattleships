using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public interface IInputHandler
    {
        string GetUserInput();
        int ValidateInput(string userInput);
        (int, int) ConvertInputToTuple(string userInput);
    }
}
