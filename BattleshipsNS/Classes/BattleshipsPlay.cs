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
        private readonly InputHandler Inputs;
        private readonly OutputHandler Outputs = new OutputHandler();

        public BattleshipsPlay(GameBoard gameBoard, GameParts gameParts)
        {
            GameParts = gameParts;
            GameBoard = gameBoard;
          
            Inputs = new InputHandler(GameBoard.BoardSize);

            while(gameParts.CheckAllShipsSunk())
            {
                int updatedMessageCodes;

                string target = Inputs.GetUserInput();
                int messageCodes = Inputs.ValidateInput(target); //MessageCode add Input_InvalidColumn OR Input_InvalidRow.

                if (messageCodes == 0)
                {
                    //Get Target
                    (int targetRow, int targetColumn) = Inputs.ConvertInputToTuple(target);
                    BoardSpace TargetCell = GameBoard.PlayGrid[targetRow, targetColumn];

                    //Assess Target Occupied
                    if (TargetCell.Occupied)
                    {
                        //Assess Target Content
                        if(TargetCell.Contents == 'x')
                        {
                            updatedMessageCodes = messageCodes + 4 + 16; //MessageCode add Target_Repeat AND Target_Hit.
                        }
                        else
                        {
                            TargetCell.Contents = 'x';
                            updatedMessageCodes = messageCodes + 16; //MessageCode add Target_Hit.
                        }

                    }
                    else
                    {
                        //Assess Target Content
                        if (TargetCell.Contents == 'o')
                        {
                            updatedMessageCodes = messageCodes + 4 + 8; //MessageCode add Target_Repeat AND Target_Miss.
                        }
                        else
                        {
                            TargetCell.Contents = 'o';
                            updatedMessageCodes = messageCodes + 8; //MessageCode add Target_Miss.
                        }
                    }

                    //Display Appropriate Messages.
                    Outputs.GenerateMessages(updatedMessageCodes);

                    //Display Latest Board State.
                    Outputs.DisplayPlayGrid(GameBoard);
                }
                else
                {
                    //Display Appropriate Messages based on code.
                    Outputs.GenerateMessages(messageCodes);
                }

            }
            //Display Game Victory Message
            Outputs.GenerateMessages(32);
        }
    }
}
