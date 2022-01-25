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
            // Program Default settings
            int gridSize = 10;
            string[] roster = {"Battleship","Destroyer","Destroyer"};

            //Create Play grid
            new Grid(gridSize);

            //Create 3 Ship
            new Ship();
            new Ship();
            new Ship();

            //Console Hold-Open Message
            Console.WriteLine("Program Finished. Press any Key to Close...");
            System.Console.ReadLine();
        }
    }
}
