using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IOutputHandler
    {
        /*
         * Responsibility: Management of User Interface (messages and console display).
         * 
         * The Output Handler should have (Fields or Properties):
         *  •	No fields or properties.
         *  
         *  The system should be able to (Methods, Events, Operators):
         *  •	Display appropriate messages
         *      o	Input integer.
         *      o	Return void.
         *      
         */
        void GenerateMessage(int MessageID);

    }
}
