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
        public string GenerateMessages(int MessagesCode, int SunkShipCount)
        {
            //StringBuilder messagesBuilder = new StringBuilder("");

            Messages messageSwitch = (Messages)MessagesCode;
            if (messageSwitch.HasFlag(Messages.Winner))
            {
                Console.WriteLine("\tYou won the game.");
                Console.WriteLine("\tCongratulations");
                Console.WriteLine();
            }
            else
            {
                if (messageSwitch.HasFlag(Messages.Invalid_Format))
                {
                    Console.WriteLine("\tYour input is invalid.");
                    Console.WriteLine("\tIt was not the correct format.");
                    Console.WriteLine();
                }

                if (messageSwitch.HasFlag(Messages.Invalid_Column))
                {
                    Console.WriteLine("\tYour input is invalid.");
                    Console.WriteLine("\tThe column letter provided doesnt exist on this grid.");
                    Console.WriteLine();
                }

                if (messageSwitch.HasFlag(Messages.Invalid_Row))
                {
                    Console.WriteLine("\tYour input is invalid.");
                    Console.WriteLine("\tThe row number provided doesnt exist on this grid.");
                    Console.WriteLine();
                }

                if (messageSwitch.HasFlag(Messages.Repeat))
                {
                    Console.WriteLine("\tYou shot at that target already.");
                    Console.WriteLine("\tYou won't win the game that way.");
                    Console.WriteLine();
                }

                if (messageSwitch.HasFlag(Messages.Missed))
                {
                    Console.WriteLine("\tYou shot splashes harmlessly into the sea.");
                    Console.WriteLine("\tMaybe next time.");
                    Console.WriteLine();
                }

                if (messageSwitch.HasFlag(Messages.Hit))
                {
                    Console.WriteLine("\tYou hit something.");
                    Console.WriteLine("\tWell done!");
                    Console.WriteLine();
                }

                if (SunkShipCount == 1)
                {
                    Console.WriteLine("\tThere is " + SunkShipCount + " ship left.");
                }
                else
                {
                    Console.WriteLine("\tThere are " + SunkShipCount + " ship(s) left.");
                }
            }
            Console.WriteLine();

            return "butt";
        }

        public string GeneratePlayGrid(GameBoard gameBoard)
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

            string Display = playGridBuilder.ToString();
            return(Display);
        }
    }
}