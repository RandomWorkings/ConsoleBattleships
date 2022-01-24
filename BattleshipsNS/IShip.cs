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
         * ID. String.
         * Length. Integer.
         * Orientation. Integer.
         * Start Location. Grid Cell (Object).
         * Array of Sections. Containing Null or a Grid Cell reference. 
         * Sunk Flag. Boolean.
         * 
         * Set the Orientation. By inputting an Integer. Returns void.
         * Set the Start Location. By inputting a Grid Cell. Returns void.
         * Indirectly Set the Array of Sections. Set by computation linked to Orientation and Start Location. Returns void.
         * Indirectly Set the Sunk Flag. Set by computation linked to Section contents. Returns void.
         * Retrieve the Sunk Flag. Returns Boolean Value
         *
         */
        bool HasShipBeenSunk { get; }
    }
}
