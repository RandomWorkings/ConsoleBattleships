using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IShipRoster
    {
        /*
         * 
         * Responsibility: Management of ship roster class.
         * 
         * A ship roster should have (Fields or Properties):
         *  •	An array of ships
         *  
         * The system should be able to (Methods, Events, Operators):
         *  •	Set a ship roster
         *      o	Input array of ship types
         *      o	Return void.
         *  •	Check if all ships are sunk.
         *      o	Return Boolean.
         *      
         */
        Ship[] Roster { get; set; }

        void SetShipRoster(Enum[] roster);
        bool CheckRosterSunk();
    }
}
