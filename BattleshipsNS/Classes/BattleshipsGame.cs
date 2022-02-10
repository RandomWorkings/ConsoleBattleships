namespace BattleshipsNS
{
    public class BattleshipsGame : IBattleshipsGame
    {
        public IBattleshipsBoard Board { get; private set; }
        public IBattleshipsParts Parts { get; private set; }
        public ITextIO TextIO { get; private set; }
        public IInputHandler InputHandler { get; private set; }
        public IOutputGenerator UI { get; private set; }

        public BattleshipsGame(IBattleshipsSetup gameSetup, ITextIO textIO, IInputHandler inputHandler, IOutputGenerator outputGenerator)
        {
            TextIO = textIO;
            InputHandler = inputHandler;
            UI = outputGenerator;

            Board = gameSetup.GameBoard;
            Parts = gameSetup.GameParts;
        }
        public void RunGame()
        {
            while (Parts.ShipCount != 0)
            {
                int updatedMessageCodes;
                int finalMessageCodes;
                //Display Latest Board State.
                string boardUI = UI.GenerateGameUI(Board);
                TextIO.OutputText(boardUI);

                // User Input retreival and validation
                string inputRequest = UI.GenerateInputRequestMessage();
                TextIO.OutputText(inputRequest);
                string userInput = TextIO.InputText();
                string target = userInput.ToUpper();
                int messageCodes = InputHandler.ValidateInput(target);
                
                if (messageCodes == 0) // Only possible with a valid input.
                {
                    //Get target value from input.
                    (int targetRow, int targetColumn) = InputHandler.ConvertInputToTuple(target);
                    IBoardSpace TargetCell = Board.PlayGrid[targetRow, targetColumn];

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
                    finalMessageCodes = updatedMessageCodes + Parts.UpdateShipCount();
                    string feedback = UI.GenerateFeedbackMessage(finalMessageCodes, Parts.ShipCount);
                    TextIO.OutputText(feedback);
                }
                else
                {
                    //Display appropriate output messages.
                    updatedMessageCodes = messageCodes + Parts.UpdateShipCount();
                    string feedback = UI.GenerateFeedbackMessage(updatedMessageCodes, Parts.ShipCount);
                    TextIO.OutputText(feedback);
                }
            }
            //Display appropriate output messages.
            Parts.UpdateShipCount();
            string finalFeedback = UI.GenerateFeedbackMessage((int)Messages.Winner, Parts.ShipCount);
            TextIO.OutputText(finalFeedback);
        }
    }
}