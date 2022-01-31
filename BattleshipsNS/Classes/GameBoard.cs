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
           //Parameter Assignment
           this.BoardSize = boardSize;
            
            //Array Initialization and Population
            PlayGrid = new BoardSpace[gridSize, gridSize];
            char columnLetter = 'A';
            for (int row = 0; row < gridSize; row++)
            {
                for (int column = 0; column < gridSize; column++)
                {
                    PlayGrid[row, column] = new BoardSpace(row + 1, columnLetter);
                }
                columnLetter++;
            }
        }

        // Methods, Events, Operators
        public BoardSpace GetTargetGridCell(string gridCell)
        { return new BoardSpace(1, 'A'); }
    }
}