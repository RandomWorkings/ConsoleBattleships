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
        readonly Random rand = new Random();

        // Constructor Declaration of Class
        public ValueGenerator()
        { }

        // Methods, Events, Operators
        public int GetRandomOrientation()
        {
            return rand.Next(1, 3); // number between 1 and 2
        }
        
        public (int, int) GetRandomLocation(int refOrientation, int refLength, int refSize)
        {
            int columnLimit;
            int rowLimit;

            switch (refOrientation)
            {
                case 2: //Vertical
                    columnLimit = refSize + 1 - refLength;
                    rowLimit = refSize + 1;
                    break;

                default: // Horizontal
                    columnLimit = refSize + 1;
                    rowLimit = refSize + 1 - refLength;
                    break;
            }
            
            int column = rand.Next(1, columnLimit);
            int row = rand.Next(1, rowLimit);             
            return (column, row);
        }
    }
}
