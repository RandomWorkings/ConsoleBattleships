using ProgramNS;
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

    public class BattleshipsOutputGenerator : IOutputGenerator
    {
        private readonly string NewLine = Environment.NewLine;
        private readonly string Tab = "\t";

        public string GenerateInputRequest()
        {
            StringBuilder requestBuilder = new StringBuilder("");

            requestBuilder.AppendLine($@"{Tab}Enter Target Grid Space. Example target: A1{NewLine}{Tab}Press CRTL + C to quit");

            string request = requestBuilder.ToString();
            return request;
        }

        public string GenerateMessages(int MessagesCode, int SunkShipCount)
        {
            StringBuilder messagesBuilder = new StringBuilder("");

            Messages messageSwitch = (Messages)MessagesCode;

            // Input Feedback
            if (messageSwitch.HasFlag(Messages.Invalid_Format) || messageSwitch.HasFlag(Messages.Invalid_Column) || messageSwitch.HasFlag(Messages.Invalid_Row))
            {
                messagesBuilder.AppendLine($@"{Tab}Your input is invalid.");
            }
            if (messageSwitch.HasFlag(Messages.Invalid_Format))
            {
                messagesBuilder.AppendLine($@"{Tab}The input was not in the correct format.");
            }
            if (messageSwitch.HasFlag(Messages.Invalid_Column))
            {
                messagesBuilder.AppendLine($@"{Tab}The column letter provided doesnt exist on this grid.");
            }
            if (messageSwitch.HasFlag(Messages.Invalid_Row))
            {
                messagesBuilder.AppendLine($@"{Tab}The row number provided doesnt exist on this grid.");
            }
            // Action Outcome Feedback
            if (messageSwitch.HasFlag(Messages.Repeat))
            {
                messagesBuilder.AppendLine($@"{Tab}You shot at that target already.{NewLine}{Tab}You won't win the game that way.");
            }
            if (messageSwitch.HasFlag(Messages.Missed))
            {
                messagesBuilder.AppendLine($@"{Tab}You shot splashes harmlessly into the sea.{NewLine}{Tab}Maybe next time.");
            }
            if (messageSwitch.HasFlag(Messages.Hit))
            {
                messagesBuilder.AppendLine($@"{Tab}You hit something.{NewLine}{Tab}Well done!");
            }
            if (messageSwitch.HasFlag(Messages.Sunk))
            {
                messagesBuilder.AppendLine($@"{NewLine}{Tab}You sunk a vessel.");
            }
            if (messageSwitch.HasFlag(Messages.Winner))
            {
                messagesBuilder.AppendLine($@"{Tab}You won the game.{NewLine}{Tab}Congratulations");
            }
            // Board State Feedback
            else
            {
                if (SunkShipCount == 1)
                {
                    messagesBuilder.AppendLine($@"{NewLine}{Tab}There is {SunkShipCount} ship left.");
                }
                else
                {
                    messagesBuilder.AppendLine($@"{NewLine}{Tab}There are {SunkShipCount} ship(s) left.");
                }
            }

            string message = messagesBuilder.ToString();
            return message;
        }

        public string GeneratePlayGridUI(BattleshipsBoard gameBoard)
        {
            char columnLetter = 'A';
            int rowNumber = 1;

            // Top Left Corner
            StringBuilder playGridBuilder = new StringBuilder($"{Tab}    |");

            // Table Header and Column Titles
            for (int column = 1; column <= gameBoard.BoardSize; column++)
            {
                playGridBuilder.Append($" {columnLetter} |");
                columnLetter++;
            }
            playGridBuilder.AppendLine($"");

            // Row Titles and Content
            for (int row = 0; row < gameBoard.BoardSize; row++)
            {
                if (row < 9)
                {
                    playGridBuilder.Append($"{Tab}  {rowNumber} |");
                }
                else
                {
                    playGridBuilder.Append($"{Tab} {rowNumber} |");
                }
                rowNumber++;

                for (int column = 0; column < gameBoard.BoardSize; column++)
                {
                    BattleshipsBoardSpace cell = gameBoard.PlayGrid[row, column];

                    if (cell.Contents == null)
                    {
                        playGridBuilder.Append($"   |");
                    }
                    else
                    {
                        playGridBuilder.Append($" {cell.Contents} |");
                    }

                }
                playGridBuilder.AppendLine($"");
            }

            string ui = playGridBuilder.ToString();
            return (ui);
        }
    }
}