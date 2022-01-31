using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class GameParts : IGameParts
    {
        public Ship[] Ships { get; private set; }

        public GameParts(ShipTypes[] shipsList)
        {
            int shipCount = shipsList.Length;
            Ships = new Ship[shipCount];

            // Fill Ship Array with Ships
            for (int i = 0; i < shipCount; i++)
            {
                ShipTypes shipType = shipsList[i];
                Ships[i] = new Ship(shipType, i+1);
            }
        }

        public bool CheckAllShipsSunk()
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