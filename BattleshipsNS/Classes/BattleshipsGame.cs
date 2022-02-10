namespace BattleshipsNS
{
    public class BattleshipsGame : IBattleshipsGame
    {
        public IBattleshipsBoard Board { get; private set; }
        public IBattleshipsParts Parts { get; private set; }
        public ITextIO TextIO { get; private set; }
        public IInputHandler InputHandler { get; private set; }
        public IOutputGenerator OutputGenerator { get; private set; }

        private readonly InputHandler Inputs;
        private readonly OutputGenerator Outputs = new OutputGenerator();
        private readonly ConsoleIO ConsoleIO;

        public BattleshipsGame(IBattleshipsSetup gameSetup, ITextIO textIO, IInputHandler inputHandler, IOutputGenerator outputGenerator)
        {
            TextIO = textIO;
            InputHandler = inputHandler;
            OutputGenerator = outputGenerator;

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
                string playGridUI = Outputs.GenerateGameUI(Board);
                ConsoleIO.OutputText(playGridUI);

                // User Input retreival and validation
                string inputRequest = Outputs.GenerateInputRequestMessage();
                ConsoleIO.OutputText(inputRequest);
                string userInput = ConsoleIO.InputText();
                string target = userInput.ToUpper();
                int messageCodes = Inputs.ValidateInput(target);
                
                if (messageCodes == 0) // Only possible with a valid input.
                {
                    //Get target value from input.
                    (int targetRow, int targetColumn) = Inputs.ConvertInputToTuple(target);
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
                    string feedback = Outputs.GenerateFeedbackMessage(finalMessageCodes, Parts.ShipCount);
                    ConsoleIO.OutputText(feedback);
                }
                else
                {
                    //Display appropriate output messages.
                    updatedMessageCodes = messageCodes + Parts.UpdateShipCount();
                    string feedback = Outputs.GenerateFeedbackMessage(updatedMessageCodes, Parts.ShipCount);
                    ConsoleIO.OutputText(feedback);
                }
            }
            //Display appropriate output messages.
            Parts.UpdateShipCount();
            string finalFeedback = Outputs.GenerateFeedbackMessage((int)Messages.Winner, Parts.ShipCount);
            ConsoleIO.OutputText(finalFeedback);
        }
    }
}