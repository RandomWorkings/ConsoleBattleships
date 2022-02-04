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
        Was_An_Invalid_Format = 1,
        Was_An_Invalid_Coulumn_Input = 2,
        Was_An_Invalid_Row_Input = 4,
        Was_A_Repeat = 8,
        Missed = 16,
        Hit = 32,
        You_Are_The_Winner = 64,
        Ships_Remain = 128
    }

    public class OutputHandler : IOutputHandler
    {
        public OutputHandler()
        { }
        public void GenerateMessages(int MessagesCode)
        {
            Console.WriteLine("\t" + (Messages)MessagesCode);
            Console.WriteLine();

            Messages messageSwitch = (Messages)MessagesCode;
            if (messageSwitch.HasFlag(Messages.You_Are_The_Winner)){Console.WriteLine("You Won the game, Congratulations");}
             
        }

        public void GenerateMessages(int MessagesCode, int SunkShipCount)
        {
            Console.WriteLine("\tYour Shot: "+(Messages)MessagesCode);
            Console.WriteLine("\t" + SunkShipCount + " ships remain.");
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
