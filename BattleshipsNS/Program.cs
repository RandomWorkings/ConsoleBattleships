using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    class Program
    {
        static void Main( )
        {
            /*
            //Program Instances
            //InputHandler Inputs = new InputHandler();
            OutputHandler Outputs = new OutputHandler();

            // Program Default settings
            int boardSize = 10;
            string[] roster = {"Battleship","Destroyer","Destroyer"};

            // Game Setup
            ShipRoster GameParts = new ShipRoster(roster);
            Grid GameBoard = new Grid(boardSize);

            foreach (Ship ship in GameParts.Roster)
            {
                //ship.PlaceShip(GameBoard);
            }
            */
            ValueGenerator generator = new ValueGenerator();
            for (int i = 0; i < 20; i++)
            {
                int orient = generator.GetRandomOrientation();
                Console.WriteLine(orient);
                Console.WriteLine(generator.GetRandomLocation(orient, 4, 10));
            }

            // Game Play
            //Outputs.DisplayPlayGrid(GameBoard);

            //Console Hold-Open Message
            Console.WriteLine();
            Console.WriteLine("Program Finished. Press any Key to Close...");
            System.Console.ReadLine();
        }
    }
}
