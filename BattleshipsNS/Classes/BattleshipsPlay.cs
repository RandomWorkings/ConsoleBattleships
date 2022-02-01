﻿using System;
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

            while (gameParts.ShipCount != 0)
            {
                int updatedMessageCodes;

                //Display Latest Board State.
                Outputs.DisplayPlayGrid(GameBoard);

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
                        updatedMessageCodes = messageCodes + (int)Messages.Hit;
                        //Assess Target Content
                        if (TargetCell.Contents == 'x')
                        {
                            updatedMessageCodes = messageCodes + (int)Messages.Was_A_Repeat;
                        }
                        else
                        {
                            TargetCell.Contents = 'x';
                        }
                    }
                    else
                    {
                        updatedMessageCodes = messageCodes + (int)Messages.Missed; //MessageCode add Target_Miss.
                        //Assess Target Content
                        if (TargetCell.Contents == 'o')
                        {
                            updatedMessageCodes = messageCodes + (int)Messages.Was_A_Repeat; //MessageCode add Target_Repeat AND Target_Miss.
                        }
                        else
                        {
                            TargetCell.Contents = 'o';
                        }
                    }

                    //Display Appropriate Messages.
                    gameParts.UpdateShipCount();
                    Outputs.GenerateMessages(updatedMessageCodes, gameParts.ShipCount);
                }
                else
                {
                    //Display Appropriate Messages based on code.
                    gameParts.UpdateShipCount();
                    Outputs.GenerateMessages(messageCodes, gameParts.ShipCount);
                }
            }
            //Display Game Victory Message
            Outputs.GenerateMessages((int)Messages.You_Are_The_Winner, gameParts.ShipCount);
            Outputs.DisplayPlayGrid(GameBoard);
        }
    }
}
