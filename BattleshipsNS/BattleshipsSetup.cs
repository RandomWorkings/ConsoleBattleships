using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public enum ShipTypes
    {
        Battleship = 4,
        Destroyer = 3
    };

    class BattleshipsSetup : IBattleshipsSetup
    {
        public BattleshipsSetup()
        {
            // Program Default settings
            int boardSize = 10;
            ShipTypes[] shipList = { ShipTypes.Battleship, ShipTypes.Destroyer, ShipTypes.Destroyer };

            GameParts GameParts = new GameParts(shipList);
            GameBoard GameBoard = new GameBoard(boardSize);

            foreach (Ship ship in GameParts.Ships)
            {
                 ship.PlaceShip(GameBoard);
            }
 }
        
}
}
