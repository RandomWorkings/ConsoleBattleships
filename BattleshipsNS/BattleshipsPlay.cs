using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    class BattleshipsPlay : IBattleshipsPlay
    {
        public BattleshipsPlay()
        {
            //Program Instances
            //InputHandler Inputs = new InputHandler();
            OutputHandler Outputs = new OutputHandler();

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
            GameParts.CheckRosterSunk();

            //Display Latest Board State
            Outputs.DisplayPlayGrid(GameBoard);
        }
    }
}
