using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
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
            for (int column = 1; column <= UIGrid.Size; column++)
            {
                Console.Write(" " + columnLetter + " |");
                columnLetter++;
            }
            Console.WriteLine();

            //
            for (int row = 0; row < UIGrid.Size; row++)
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

                for (int column = 0; column < UIGrid.Size; column++)
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
