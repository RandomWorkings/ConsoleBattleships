using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class GameParts : IGameParts
    {
        // Fields, Properties
        public Ship[] Ships { get; private set; }

        // Constructor Declaration of Class
        public GameParts(ShipTypes[] roster)
        {
            Ships = new Ship[roster.Length];

            for(int i = 0; i < roster.Length; i++)
            {
                Ships[i] = new Ship(roster[i], i+1);
            }
        }

        // Methods, Events, Operators
        public bool CheckRosterSunk()
        {
            bool AllSunk = false;
           
            foreach(Ship ship in Ships)
            {
                ship.UpdateSunkFlag();
                if (ship.SunkFlag)
                {
                    AllSunk = true;
                }
                else
                {
                    AllSunk = false;
                }
            }

            return AllSunk;
        }

    }
}
