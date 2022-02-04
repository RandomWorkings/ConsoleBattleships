﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class OutputHandler : IOutputHandler
    {
        public OutputHandler()
        { }

        public void GenerateMessages(int MessagesCode, int SunkShipCount)
        {
            Messages messageSwitch = (Messages)MessagesCode;
            if (messageSwitch.HasFlag(Messages.Invalid_Format))
            {
                Console.WriteLine("\tYour Input is invalid.\n\tIt was not the correct format.\n");
            }

            if (messageSwitch.HasFlag(Messages.Invalid_Column))
            {
                Console.WriteLine("\tYour Input is invalid.\n\tThe column letter provided doesnt exist on this grid.\n");
            }

            if (messageSwitch.HasFlag(Messages.Invalid_Row))
            {
                Console.WriteLine("\tYour Input is invalid.\n\tThe row number provided doesnt exist on this grid.\n");
            }

            if (messageSwitch.HasFlag(Messages.Repeat))
            {
                Console.WriteLine("\tYou shot at that target already.\n\tYou won't win the game that way.\n");
            }

            if (messageSwitch.HasFlag(Messages.Missed))
            {
                Console.WriteLine("\tYou shot splashes harmlessly into the sea.\n\tMaybe next time.\n");
            }

            if (messageSwitch.HasFlag(Messages.Hit))
            {
                Console.WriteLine("\tYou Hit something.\n\tWell Done!\n");
            }

            Console.WriteLine("\t" + SunkShipCount + " ships remain.");
            
            if (messageSwitch.HasFlag(Messages.Winner))
            {
                Console.WriteLine("\tYou Won the game.\n\tCongratulations\n");
            }
            
            Console.WriteLine();
        }

        public void DisplayPlayGrid(GameBoard UIGrid)
        {
            char columnLetter = 'A';
            int rowNumber = 1;

            //Top Corner
            Console.Write("\t    |");

            //Column Headers
            for (int column = 1; column <= UIGrid.BoardSize; column++)
            {
                Console.Write(" " + columnLetter + " |");
                columnLetter++;
            }
            Console.WriteLine();

            //
            for (int row = 0; row < UIGrid.BoardSize; row++)
            {
                if(row<9)
                {
                    Console.Write("\t  " + rowNumber + " |"); 
                }
                else
                {
                    Console.Write("\t " + rowNumber + " |");
                }
                rowNumber++;

                for (int column = 0; column < UIGrid.BoardSize; column++)
                {
                    BoardSpace cell = UIGrid.PlayGrid[row, column];

                    if(cell.Contents == null)
                    {
                        Console.Write("   |"); 
                    }
                    else
                    {
                        Console.Write(" " + cell.Contents + " |");
                    }
                    
                }
                Console.WriteLine("");
            }
        }
    }
}
