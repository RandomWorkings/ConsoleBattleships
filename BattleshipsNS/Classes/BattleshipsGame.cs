namespace BattleshipsNS
{
    public class BattleshipsGame : IBattleshipsGame
    {
        public IBattleshipsBoard Board { get; private set; }
        public IBattleshipsParts Parts { get; private set; }
        public ITextIO TextIO { get; private set; }
        public IInputHandler InputHandler { get; private set; }
        public IOutputGenerator UI { get; private set; }
        private string UserInput;
        private Messages Feedback = 0;

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
                InteractWithUser();
                Feedback |= InputHandler.ValidateInput(UserInput);

                if (Feedback == 0) // Only possible with a valid input.
                {
                    CheckTargetStatus();
                    DisplayFeedback();
                }
                else
                {
                    DisplayFeedback();
                }
                Feedback = 0;
            }
            Feedback |= Messages.Winner;
            DisplayFeedback();
        }

        private void InteractWithUser()
        {
            string boardUI = UI.GenerateGameUI(Board);
            TextIO.OutputText(boardUI);

            string inputRequest = UI.GenerateInputRequestMessage();
            TextIO.OutputText(inputRequest);

            string userInput = TextIO.InputText();           
            UserInput = userInput.ToUpper();
        }
        private void CheckTargetStatus()
        {
            //Get target value from input.
            (int targetRow, int targetColumn) = InputHandler.ConvertInputToTuple(UserInput);
            IBoardSpace TargetCell = Board.PlayGrid[targetRow, targetColumn];

            //Assess target occupied and respond.
            if (TargetCell.Occupied)
            {
                Feedback |= Messages.Hit;
                //Assess target content and respond.
                if (TargetCell.Contents == 'x') // x indicates a targeted and occupied location.
                {
                    Feedback |= Messages.Repeat;
                }
                else
                {
                    TargetCell.Contents = 'x'; // x indicates a targeted and occupied location.
                }
            }
            else
            {
                Feedback |= Messages.Missed;

                //Assess target content and respond.
                if (TargetCell.Contents == 'o') // o indicates a targeted and vacant location.
                {
                    Feedback |= Messages.Repeat;
                }
                else
                {
                    TargetCell.Contents = 'o'; // o indicates a targeted and vacant location.
                }
            }
        }

        private void DisplayFeedback()
        {
            Feedback |= Parts.UpdateShipCount();
            string outputs = UI.GenerateFeedbackMessage(Feedback, Parts.ShipCount);
            TextIO.OutputText(outputs);
        }
    }   
}