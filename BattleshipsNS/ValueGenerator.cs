using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    class ValueGenerator : IValueGenerator
    {
        // Fields, Properties

        // Constructor Declaration of Class
        public ValueGenerator()
        { }

        // Methods, Events, Operators
        public int GetRandomOrientation()
        { return 1; }
        
        public GridCell GetRandomLocation()
        { return new GridCell(1,'A'); }
    }
}
