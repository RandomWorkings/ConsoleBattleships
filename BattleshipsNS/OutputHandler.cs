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
            //char columnLetter = 'A';
                        
            for (int column = 0; column < UIGrid.Size; column++)
            { 
                for(int row = 0; row < UIGrid.Size; row++)
                {
                    GridCell cell = UIGrid.PlayGrid[column, row];

                    Console.Write(" " + cell.ID + " ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
