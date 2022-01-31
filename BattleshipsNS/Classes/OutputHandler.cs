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
        Input_InvalidLength = 1,
        Input_InvalidCharacter = 2,
        Input_InvalidInteger = 4,
        Target_Repeat = 8,
        Target_Miss = 16,
        Target_Hit = 32,
        Winner = 62
    }

    public class OutputHandler : IOutputHandler
    {
        // Fields, Properties

        // Constructor Declaration of Class
        public OutputHandler()
        { }

        // Methods, Events, Operators
        public void GenerateMessage(int MessageID)
        { }

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
