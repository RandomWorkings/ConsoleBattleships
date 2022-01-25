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

        static void Main(string[] args)
        {
            //Program Instances
            ValueGenerator Generator = new ValueGenerator();
            InputHandler Inputs = new InputHandler();
            OutputHandler Outputs = new OutputHandler();

            // Program Default settings
            int gridSize = 10;
            string[] roster = {"Battleship","Destroyer","Destroyer"};

            // Game Setup
            Grid PlayGrid = new Grid(gridSize);

            //Testing ValueGenerator
            Console.WriteLine(Generator.GetRandomOrientation());
            Console.WriteLine(Generator.GetRandomLocation());

            //Testing Input Handler
            Console.WriteLine(Inputs.ValidateInput(gridSize, "A1"));
            Console.WriteLine(Inputs.ValidateInput(gridSize, "Butts"));
            Console.WriteLine(Inputs.ValidateInput(gridSize, "K11"));

            //Console Hold-Open Message
            Console.WriteLine("Program Finished. Press any Key to Close...");
            System.Console.ReadLine();
        }
    }
}
