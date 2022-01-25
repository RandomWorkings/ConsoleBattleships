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
        public int Size { get; set; }
        public GridCell[,] PlayGrid { get; set; }

        // Constructor Declaration of Class
        public Grid(int gridSize)
        {
            Size = gridSize;
            char columnLetter = 'A';

            GridCell[,] GameGrid = new GridCell[gridSize, gridSize];

            for (int column = 0; column < gridSize; column++)
            {
                for (int row = 0; row < gridSize; row++)
                {
                    GameGrid[column, row] = new GridCell(row + 1, columnLetter);
                }
                Console.WriteLine();
                columnLetter++;
            }
        }

        // Methods, Events, Operators
        public GridCell GetTargetGridCell(string gridCell)
        { return new GridCell(1,'A'); }
    }
}
