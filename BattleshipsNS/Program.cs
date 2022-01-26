using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    class Program
    {
        static void Main()
        {
            bool Running = true;
            //Program Loop
            while (Running)
            {
                //Program Instances
                //InputHandler Inputs = new InputHandler();
                OutputHandler Outputs = new OutputHandler();

                // Program Default settings
                int boardSize = 10;
                string[] roster = { "Battleship", "Destroyer", "Destroyer" };

                // Game Setup
                ShipRoster GameParts = new ShipRoster(roster);
                Grid GameBoard = new Grid(boardSize);

                foreach (Ship ship in GameParts.Roster)
                {
                    ship.PlaceShip(GameBoard);
                }

                // Game Play Loop

                // Receive and Validate User Input
                int targetRow = 0;
                int targetColumn = 0;

                // Assess Target - Display Appropriate Message
                GridCell TargetCell = GameBoard.PlayGrid[targetRow, targetColumn];
                
                if (TargetCell.Occupied)
                {
                    TargetCell.Contents = 'x';
                }
                else
                {
                    TargetCell.Contents = 'o';
                }
                
                //Check Win Condition
                GameParts.CheckRosterSunk();
                
                //Display Latest Board State
                Outputs.DisplayPlayGrid(GameBoard);
                

                //Repeat Program Option
                Console.WriteLine();
                Console.WriteLine("Press Enter to repeat");
                Console.WriteLine("Press any other button to quit");
                Console.WriteLine();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        break;

                    default:
                        Running = false;
                        break;
                }
            }
        }
    }
}
