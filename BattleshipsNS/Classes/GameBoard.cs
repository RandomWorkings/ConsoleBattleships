using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{

    public class GameBoard : IGameBoard
    {
        // Fields, Properties
        public int BoardSize { get; private set; }
        public BoardSpace[,] PlayGrid { get; private set; }

        // Constructor Declaration of Class
        public GameBoard(int boardSize)
        {
           // Set Board Size
           this.BoardSize = boardSize;
            
            // Create Play Grid
            PlayGrid = new BoardSpace[BoardSize, BoardSize];

            // Fill Play Grid With uniquely ID'd Board Spaces 
            int rowCount = PlayGrid.GetLength(0);
            int columnCount = PlayGrid.GetLength(1);
            char columnLetter = 'A';
            
            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    PlayGrid[row, column] = new BoardSpace(row + 1, columnLetter);
                }
                columnLetter++;
            }
        }

        // Methods, Events, Operators
        public BoardSpace GetTargetGridCell(string gridCell)
        {
            return new BoardSpace(1, 'A');
        }
    }
}