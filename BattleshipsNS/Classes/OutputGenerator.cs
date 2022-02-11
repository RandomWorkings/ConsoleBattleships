using System;
using System.Text;

namespace BattleshipsNS
{
    [Flags]
    public enum Messages
    {
        None = 0,
        Invalid_Format = 1,
        Invalid_Column = 2,
        Invalid_Row = 4,
        Repeat = 8,
        Missed = 16,
        Hit = 32,
        Sunk = 64,
        Winner = 128
    }

    public class OutputGenerator : IOutputGenerator
    {
        private readonly string NewLine = Environment.NewLine;
        private readonly string Tab = "\t";

        public string GenerateInputRequestMessage()
        {
            StringBuilder RequestBuilder = new StringBuilder("");

            RequestBuilder.AppendLine($@"{Tab}Enter Target Grid Space. Example target: A1{NewLine}{Tab}Press CRTL + C to quit");

            string request = RequestBuilder.ToString();
            return request;
        }

        public string GenerateFeedbackMessage(Messages MessageSwitch, int SunkShipCount)
        {
            StringBuilder FeedbackMessagesBuilder = new StringBuilder("");

            // Input Feedback
            if (MessageSwitch.HasFlag(Messages.Invalid_Format) || MessageSwitch.HasFlag(Messages.Invalid_Column) || MessageSwitch.HasFlag(Messages.Invalid_Row))
            {
                FeedbackMessagesBuilder.AppendLine($@"{Tab}Your input is invalid.");
            }
            if (MessageSwitch.HasFlag(Messages.Invalid_Format))
            {
                FeedbackMessagesBuilder.AppendLine($@"{Tab}The input was not in the correct format.");
            }
            if (MessageSwitch.HasFlag(Messages.Invalid_Column))
            {
                FeedbackMessagesBuilder.AppendLine($@"{Tab}The column letter provided doesnt exist on this grid.");
            }
            if (MessageSwitch.HasFlag(Messages.Invalid_Row))
            {
                FeedbackMessagesBuilder.AppendLine($@"{Tab}The row number provided doesnt exist on this grid.");
            }
            // Action Outcome Feedback
            if (MessageSwitch.HasFlag(Messages.Repeat))
            {
                FeedbackMessagesBuilder.AppendLine($@"{Tab}You shot at that target already.{NewLine}{Tab}You won't win the game that way.");
            }
            if (MessageSwitch.HasFlag(Messages.Missed))
            {
                FeedbackMessagesBuilder.AppendLine($@"{Tab}You shot splashes harmlessly into the sea.{NewLine}{Tab}Maybe next time.");
            }
            if (MessageSwitch.HasFlag(Messages.Hit))
            {
                FeedbackMessagesBuilder.AppendLine($@"{Tab}You hit something.{NewLine}{Tab}Well done!");
            }
            if (MessageSwitch.HasFlag(Messages.Sunk))
            {
                FeedbackMessagesBuilder.AppendLine($@"{NewLine}{Tab}You sunk a vessel.");
            }
            if (MessageSwitch.HasFlag(Messages.Winner))
            {
                FeedbackMessagesBuilder.AppendLine($@"{Tab}You won the game.{NewLine}{Tab}Congratulations");
            }
            // Board State Feedback
            else
            {
                if (SunkShipCount == 1)
                {
                    FeedbackMessagesBuilder.AppendLine($@"{NewLine}{Tab}There is {SunkShipCount} ship left.");
                }
                else
                {
                    FeedbackMessagesBuilder.AppendLine($@"{NewLine}{Tab}There are {SunkShipCount} ship(s) left.");
                }
            }

            string message = FeedbackMessagesBuilder.ToString();
            return message;
        }

        public string GenerateGameUI(IBattleshipsBoard gameBoard)
        {
            char columnLetter = 'A';
            int rowNumber = 1;

            // Top Left Corner
            StringBuilder GameUIBuilder = new StringBuilder($"{Tab}    |");

            // Table Header and Column Titles
            for (int column = 1; column <= gameBoard.BoardSize; column++)
            {
                GameUIBuilder.Append($" {columnLetter} |");
                columnLetter++;
            }
            GameUIBuilder.AppendLine($"");

            // Row Titles and Content
            for (int row = 0; row < gameBoard.BoardSize; row++)
            {
                if (row < 9)
                {
                    GameUIBuilder.Append($"{Tab}  {rowNumber} |");
                }
                else
                {
                    GameUIBuilder.Append($"{Tab} {rowNumber} |");
                }
                rowNumber++;

                for (int column = 0; column < gameBoard.BoardSize; column++)
                {
                    IBoardSpace cell = gameBoard.PlayGrid[row, column];

                    if (cell.Contents == null)
                    {
                        GameUIBuilder.Append($"   |");
                    }
                    else
                    {
                        GameUIBuilder.Append($" {cell.Contents} |");
                    }

                }
                GameUIBuilder.AppendLine($"");
            }

            string ui = GameUIBuilder.ToString();
            return (ui);
        }
    }
}