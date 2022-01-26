using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{

    public class Grid : IGrid
    {
        // Fields, Properties
        public int Size { get; private set; }
        public GridCell[,] PlayGrid { get; private set; }

        // Constructor Declaration of Class
        public Grid(int gridSize)
        {
           //Parameter Assignment
           Size = gridSize;
            
            //Array Initialization and Population
            PlayGrid = new GridCell[gridSize, gridSize];
            char columnLetter = 'A';
            for (int row = 0; row < gridSize; row++)
            {
                for (int column = 0; column < gridSize; column++)
                {
                    PlayGrid[row, column] = new GridCell(row + 1, columnLetter);
                }
                columnLetter++;
            }
        }

        // Methods, Events, Operators
        public GridCell GetTargetGridCell(string gridCell)
        { return new GridCell(1, 'A'); }
    }
}