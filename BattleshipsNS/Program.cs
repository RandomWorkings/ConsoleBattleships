﻿using System;
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
            //Program Instances
            //InputHandler Inputs = new InputHandler();
            OutputHandler Outputs = new OutputHandler();

            // Program Default settings
            int boardSize = 10;
            string[] roster = {"Battleship","Destroyer","Destroyer"};

            // Game Setup
            ShipRoster GameParts = new ShipRoster(roster);
            Grid GameBoard = new Grid(boardSize);

            int i = 1;
            foreach (Ship ship in GameParts.Roster)
            {
                Console.WriteLine();
                Console.WriteLine("New Ship " + i++);
                ship.PlaceShip(GameBoard);
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
