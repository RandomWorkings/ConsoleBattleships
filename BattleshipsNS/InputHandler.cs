using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    class InputHandler : IInputHandler
    {
        // Fields, Properties

        // Constructor Declaration of Class
        public InputHandler()
        { }

        // Methods, Events, Operators
        public bool ValidateInput(int gridSize, string userInput)
        {
            //char ColumnLetter = 'A';

            //Check Length
            // Grid Size limit of 26 mean inputs can only be 2 or 3 char long
            if (userInput.Length >= 4)
            { return false; }

            /*
            //Check Letter
            else if ()
            { return false; }

            //Check Number
            else if ()
            { return false; }
            */

            else
            { return true; }
            
        }

    }
}
