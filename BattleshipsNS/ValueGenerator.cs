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

        // Constructor Declaration of Class
        public ValueGenerator()
        { }

        // Methods, Events, Operators
        public int GetRandomOrientation()
        {
            Random rand = new Random();
            return rand.Next(1, 3); // number between 1 and 2
        }
        
        public (int, int) GetRandomLocation(int refOrientation, int refLength, int refSize)
        {
            Random rand = new Random();
            Console.WriteLine("Random Location - Randomizer Inputs : [" + refOrientation + ", " + refLength + ", " + refSize + "]");
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
            
            int column = rand.Next(0, columnLimit);
            int row = rand.Next(0, rowLimit);
            Console.WriteLine("Random Location - Randomizer Limits : [" + rowLimit + ", " + columnLimit + "]");
            Console.WriteLine("Random Location - Start Location : [" + row + ", " + column + "]");
            return (row, column);
        }
    }
}
