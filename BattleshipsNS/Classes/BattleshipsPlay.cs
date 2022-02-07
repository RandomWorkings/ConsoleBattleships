namespace BattleshipsNS
{
    class BattleshipsPlay : IBattleshipsPlay
    {
        public GameParts GameParts { get; private set; }
        public GameBoard GameBoard { get; private set; }
        private readonly InputHandler Inputs;
        private readonly OutputGenerator Outputs = new OutputGenerator();
        private readonly ConsoleIO ConsoleIO = new ConsoleIO();

        public BattleshipsPlay(GameBoard gameBoard, GameParts gameParts)
        {
            GameParts = gameParts;
            GameBoard = gameBoard;

            Inputs = new InputHandler(GameBoard.BoardSize);

            while (gameParts.ShipCount != 0)
            {
                int updatedMessageCodes;

                //Display Latest Board State.
                string UI = Outputs.GeneratePlayGrid(GameBoard);
                ConsoleIO.WriteLine(UI);

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
                            updatedMessageCodes = messageCodes + (int)Messages.Repeat;
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
                            updatedMessageCodes = messageCodes + (int)Messages.Repeat; //MessageCode add Target_Repeat AND Target_Miss.
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
            Outputs.GenerateMessages((int)Messages.Winner, gameParts.ShipCount);
            Outputs.GeneratePlayGrid(GameBoard);
        }
    }
}