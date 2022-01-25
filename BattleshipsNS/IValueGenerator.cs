
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IValueGenerator
    {
        /*
         * Responsibility: Generation of values.
         * 
         * The Value Generator should have (Fields or Properties):
         *  •	No properties.
         *   
         * The system should be able to (Methods, Events, Operators):
         *  •	Generate an random orientation.
         *      o	Returns Integer.
         *  •	Generate an random start location.
         *      o	Returns Grid Cell.
         *      
         */

        int GetRandomOrientation();
        GridCell GetRandomLocation();

    }
}
