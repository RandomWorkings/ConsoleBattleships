using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IInputHandler
    {
        /*
         * Responsibility: Management of User Input Validation.
         * 
         * The Input Handler should have (Fields or Properties):
         *  •	No fields or properties.
         *  
         *  The system should be able to (Methods, Events, Operators):
         *  •	Check an input is valid
         *      o	Returns Boolean.
         *      
         */
        bool ValidateInput();
    }
}
