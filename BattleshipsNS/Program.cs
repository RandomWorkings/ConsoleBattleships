using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    class Program
    {
        public enum Orientation
        {
            Vertical,
            Horizontal
        };
        public enum ShipLengths
        {
            Battleship = 4,
            Destroyer = 3
        };

        static void Main( )
        {
            //Program Instances
            //ValueGenerator Generator = new ValueGenerator();
            //InputHandler Inputs = new InputHandler();
            OutputHandler Outputs = new OutputHandler();

            // Program Default settings
            int gridSize = 10;
            string[] roster = {"Battleship","Destroyer","Destroyer"};

            // Game Setup
            Grid PlayGrid = new Grid(gridSize);

            // Game Play

            Outputs.DisplayPlayGrid(PlayGrid);

            //Console Hold-Open Message
            Console.WriteLine();
            Console.WriteLine("Program Finished. Press any Key to Close...");
            System.Console.ReadLine();
        }
    }
}
