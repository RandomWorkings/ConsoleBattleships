using System;
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
        Was_An_Invalid_Column_Input = 1,
        Was_An_Invalid_Row_Input = 2,
        Repeat = 4,
        Missed = 8,
        Hit = 16,
        Winner = 32
    }

    public class OutputHandler : IOutputHandler
    {
        public OutputHandler()
        { }

        // Methods, Events, Operators
        public void GenerateMessages(int MessagesCode)
        {
            Console.WriteLine("Your Shot: "+(Messages)MessagesCode);
            Console.WriteLine();
        }

        public void DisplayPlayGrid(GameBoard UIGrid)
        {
            char columnLetter = 'A';
            int rowNumber = 1;

            //Top Corner
            Console.Write("    |");

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
                    Console.Write("  " + rowNumber + " |"); 
                }
                else
                {
                    Console.Write(" " + rowNumber + " |");
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
