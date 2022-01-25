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

        public void DisplayPlayGrid(Grid UIGrid)
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
            for (int column = 0; column < UIGrid.Size; column++)
            {
                if(column<9)
                {
                    Console.Write("  " + rowNumber + " |"); 
                }
                else
                {
                    Console.Write(" " + rowNumber + " |");
                }
                rowNumber++;

                for (int row = 0; row < UIGrid.Size; row++)
                {
                    GridCell cell = UIGrid.PlayGrid[column, row];

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
