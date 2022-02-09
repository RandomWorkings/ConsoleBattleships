﻿namespace BattleshipsNS
{
    public class BattleshipsPlay : IBattleshipsPlay
    {
        public GameParts GameParts { get; private set; }
        public GameBoard GameBoard { get; private set; }
        private readonly InputHandler Inputs;
        private readonly OutputGenerator Outputs = new OutputGenerator();
        private readonly ConsoleIO ConsoleIO;

        public BattleshipsPlay(GameBoard gameBoard, GameParts gameParts, ConsoleIO consoleIO)
        {
            ConsoleIO = consoleIO;
            GameParts = gameParts;
            GameBoard = gameBoard;
            Inputs = new InputHandler(GameBoard.BoardSize);

            while (gameParts.ShipCount != 0)
            {
                int updatedMessageCodes;

                //Display Latest Board State.
                string playGridUI = Outputs.GeneratePlayGridUI(GameBoard);
                ConsoleIO.WriteLine(playGridUI);

                // User Input retreival and validation
                string inputRequest = Outputs.GenerateInputRequest();
                ConsoleIO.WriteLine(inputRequest);
                string userInput = ConsoleIO.ReadLine();
                string target = userInput.ToUpper();
                int messageCodes = Inputs.ValidateInput(target);
                
                if (messageCodes == 0) // Only possible with a valid input.
                {
                    //Get target value from input.
                    (int targetRow, int targetColumn) = Inputs.ConvertInputToTuple(target);
                    BoardSpace TargetCell = GameBoard.PlayGrid[targetRow, targetColumn];

                    //Assess target occupied and respond.
                    if (TargetCell.Occupied)
                    {
                        updatedMessageCodes = messageCodes + (int)Messages.Hit;
                        //Assess target content and respond.
                        if (TargetCell.Contents == 'x') // x indicates a targeted and occupied location.
                        {
                            updatedMessageCodes = messageCodes + (int)Messages.Repeat;
                        }
                        else
                        {
                            TargetCell.Contents = 'x'; // x indicates a targeted and occupied location.
                        }
                    }
                    else
                    {
                        updatedMessageCodes = messageCodes + (int)Messages.Missed;

                        //Assess target content and respond.
                        if (TargetCell.Contents == 'o') // o indicates a targeted and vacant location.
                        {
                            updatedMessageCodes = messageCodes + (int)Messages.Repeat;
                        }
                        else
                        {
                            TargetCell.Contents = 'o'; // o indicates a targeted and vacant location.
                        }
                    }

                    //Display appropriate output messages.
                    gameParts.UpdateShipCount();
                    string feedback = Outputs.GenerateMessages(updatedMessageCodes, gameParts.ShipCount);
                    ConsoleIO.WriteLine(feedback);
                }
                else
                {
                    //Display appropriate output messages.
                    gameParts.UpdateShipCount();
                    string feedback = Outputs.GenerateMessages(messageCodes, gameParts.ShipCount);
                    ConsoleIO.WriteLine(feedback);
                }
            }
            //Display appropriate output messages.
            gameParts.UpdateShipCount();
            string finalFeedback = Outputs.GenerateMessages((int)Messages.Winner, gameParts.ShipCount);
            ConsoleIO.WriteLine(finalFeedback);
        }
    }
}