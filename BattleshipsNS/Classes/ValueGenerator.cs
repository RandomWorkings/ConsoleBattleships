using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class ValueGenerator : IValueGenerator
    {
        private static readonly Random Rand = new Random();
        private static readonly object Synclock = new object();

        public int GetRandomOrientation()
        {
            lock(Synclock)
            { 
                return Rand.Next(1, 3); // number between 1 and 2
            }
        }
        
        public (int, int) GetRandomLocation(int shipOrientation, int shipLength, int boardSize)
        {
            int columnLimit;
            int rowLimit;

            switch (shipOrientation)
            {
                case 2: //Vertical, Limit Rows
                    columnLimit = boardSize;
                    rowLimit = boardSize - shipLength;
                    break;

                default: // Horizontal, Limit Columns
                    columnLimit = boardSize - shipLength;
                    rowLimit = boardSize;
                    break;
            }
            lock (Synclock)
            {
                int column = Rand.Next(0, columnLimit);
                int row = Rand.Next(0, rowLimit);
                return (row, column);
            }  
            
        }
    }
}
