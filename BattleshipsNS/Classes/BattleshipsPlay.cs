using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    class BattleshipsPlay : IBattleshipsPlay
    {
        public GameParts GameParts { get; private set; }
        public GameBoard GameBoard { get; private set; }
        private InputHandler Inputs;
        private OutputHandler Outputs;

        public BattleshipsPlay(GameBoard gameBoard, GameParts gameParts, InputHandler inputs, OutputHandler outputs)
        {
            GameParts = gameParts;
            GameBoard = gameBoard;
            Inputs = inputs;
            Outputs = outputs;

            // Receive and Validate User Input
            int targetRow = 0;
            int targetColumn = 0;

            // Assess Target - Display Appropriate Message
            BoardSpace TargetCell = GameBoard.PlayGrid[targetRow, targetColumn];

            if (TargetCell.Occupied)
            {
                TargetCell.Contents = 'x';
            }
            else
            {
                TargetCell.Contents = 'o';
            }

            //Check Win Condition
            GameParts.CheckAllShipsSunk();

            //Display Latest Board State
            Outputs.DisplayPlayGrid(GameBoard);
        }
    }
}
