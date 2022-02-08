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
        Winner = 64,
    }

    public class OutputGenerator : IOutputGenerator
    {
        public string GenerateInputRequest()
        {
            StringBuilder requestBuilder = new StringBuilder("");

            requestBuilder.AppendLine("\tEnter Target Grid Space. Example target: A1\n\tPress CRTL + C to quit");

            string request = requestBuilder.ToString();
            return request;
        }

        public string GenerateMessages(int MessagesCode, int SunkShipCount)
        {
            StringBuilder messagesBuilder = new StringBuilder("");

            Messages messageSwitch = (Messages)MessagesCode;

            if (messageSwitch.HasFlag(Messages.Invalid_Format) || messageSwitch.HasFlag(Messages.Invalid_Column) || messageSwitch.HasFlag(Messages.Invalid_Row))
            {
                messagesBuilder.AppendLine("\tYour input is invalid.");
            }
            if (messageSwitch.HasFlag(Messages.Invalid_Format))
            {
                messagesBuilder.AppendLine("\tThe input was not in the correct format.");
            }
            if (messageSwitch.HasFlag(Messages.Invalid_Column))
            {
                messagesBuilder.AppendLine("\tThe column letter provided doesnt exist on this grid.");
            }
            if (messageSwitch.HasFlag(Messages.Invalid_Row))
            {
                messagesBuilder.AppendLine("\tThe row number provided doesnt exist on this grid.");
            }
            if (messageSwitch.HasFlag(Messages.Repeat))
            {
                messagesBuilder.AppendLine("\tYou shot at that target already.\n\tYou won't win the game that way.");
            }
            if (messageSwitch.HasFlag(Messages.Missed))
            {
                messagesBuilder.AppendLine("\tYou shot splashes harmlessly into the sea.\n\tMaybe next time.");
            }
            if (messageSwitch.HasFlag(Messages.Hit))
            {
                messagesBuilder.AppendLine("\tYou hit something.\n\tWell done!");
            }
            if (messageSwitch.HasFlag(Messages.Winner))
            {
                messagesBuilder.AppendLine("\tYou won the game.\n\tCongratulations");
            }
            else
            {
                if (SunkShipCount == 1)
                {
                    messagesBuilder.AppendLine("\n\tThere is " + SunkShipCount + " ship left.");
                }
                else
                {
                    messagesBuilder.AppendLine("\n\tThere are " + SunkShipCount + " ship(s) left.");
                }
            }

            string message = messagesBuilder.ToString();
            return message;
        }

        public string GeneratePlayGridUI(GameBoard gameBoard)
        {
            char columnLetter = 'A';
            int rowNumber = 1;

            StringBuilder playGridBuilder = new StringBuilder("\t    |", 45);

            //Column Headers
            for (int column = 1; column <= gameBoard.BoardSize; column++)
            {
                playGridBuilder.Append(" " + columnLetter + " |");
                columnLetter++;
            }
            playGridBuilder.AppendLine("");

            //
            for (int row = 0; row < gameBoard.BoardSize; row++)
            {
                if (row < 9)
                {
                    playGridBuilder.Append("\t  " + rowNumber + " |");
                }
                else
                {
                    playGridBuilder.Append("\t " + rowNumber + " |");
                }
                rowNumber++;

                for (int column = 0; column < gameBoard.BoardSize; column++)
                {
                    BoardSpace cell = gameBoard.PlayGrid[row, column];

                    if (cell.Contents == null)
                    {
                        playGridBuilder.Append("   |");
                    }
                    else
                    {
                        playGridBuilder.Append(" " + cell.Contents + " |");
                    }

                }
                playGridBuilder.AppendLine("");
            }

            string ui = playGridBuilder.ToString();
            return(ui);
        }
    }
}