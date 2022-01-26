using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class ValueGenerator : IValueGenerator
    {
        // Fields, Properties
        private static readonly Random Rand = new Random();
        private static readonly object Synclock = new object();


        // Constructor Declaration of Class
        public ValueGenerator()
        { }

        // Methods, Events, Operators
        public int GetRandomOrientation()
        {
            lock(Synclock)
            { 
            return Rand.Next(1, 3); // number between 1 and 2
            }
        }
        
        public (int, int) GetRandomLocation(int refOrientation, int refLength, int refSize)
        {
            int columnLimit;
            int rowLimit;

            switch (refOrientation)
            {
                case 2: //Vertical, Limit Rows
                    columnLimit = refSize;
                    rowLimit = refSize - refLength;

                    break;

                default: // Horizontal, Limit Columns
                    columnLimit = refSize - refLength;
                    rowLimit = refSize;
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
