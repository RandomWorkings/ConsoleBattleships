using System;

namespace BattleshipsNS
{
    class Program
    {
        static void Main()
        {
            string Tab = "\t";

            bool Running = true;
            //Program Loop
            while (Running)
            {
                Console.WriteLine();

                //Default Inputs
                ShipTypes[] ShipsList = { ShipTypes.Battleship, ShipTypes.Destroyer, ShipTypes.Destroyer };

                // Setup Parts
                IGameBoard Board = new GameBoard();
                
                ITextIO ConsoleIO = new ConsoleIO();


                /*
                //Battleship Program

                BattleshipsSetup GameSetup = new BattleshipsSetup();
                new BattleshipsPlay(GameSetup.GameBoard, GameSetup.GameParts, consoleIO);
                */
                //Repeat Program Option
                Console.WriteLine($"{Tab}The Program Battleships has finished!");
                Console.WriteLine($"{Tab}Press Enter to repeat program");
                Console.WriteLine($"{Tab}Press any other button to quit");
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