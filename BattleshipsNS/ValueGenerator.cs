﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class ValueGenerator : IValueGenerator
    {
        // Fields, Properties
        Random rand = new Random();

        // Constructor Declaration of Class
        public ValueGenerator()
        { }

        // Methods, Events, Operators
        public int GetRandomOrientation()
        {
            return rand.Next(1, 3); // number between 1 and 2
        }
        
        public (int column, int row) GetRandomLocation(int gridSize)
        {
            int uppperLimit = gridSize + 1;

            int column = rand.Next(1, uppperLimit);
            int row = rand.Next(1, uppperLimit);
             
            return (column, row);
        }
    }
}
