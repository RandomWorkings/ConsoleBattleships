using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IShip
    {
        /*
         * Responsibility: Management of ship class element.
         * 
         *  A ship should have (Fields or Properties):
         *      •	ID.
         *          o	String.
         *      •	Length.
         *          o	Integer.
         *      •	Orientation.
         *          o	Integer.
         *      •	Start Location.
         *          o	Grid Cell (Object).
         *      •	Array of Sections
         *          o	Containing Null or a Grid Cell reference. 
         *      •	Sunk Flag.
         *          o	Boolean.
         *
         *  The system should be able to (Methods, Events, Operators):
         *      •	Set the Orientation.
         *          o	By inputting an Integer.
         *          o	Returns void.
         *      •	Set the Start Location.
         *          o	By inputting a Grid Cell.
         *          o	Returns void.
         *      •	Indirectly Set the Array of Sections.
         *          o	Set by computation linked to Orientation and Start Location.
         *          o	Returns void.
         *      •	Indirectly Set the Sunk Flag.
         *          o	Set by computation linked to Section contents.
         *          o	Returns void.
         *      •	Retrieve the Sunk Flag.
         *          o	Returns Boolean Value
         *
         */
    }
}
