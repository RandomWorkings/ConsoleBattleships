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

                // Setup Game
                IBattleshipsBoard board = new BattleshipsBoard(); //Creates and manages collection of BoardSpaces.
                IBattleshipsParts parts = new BattleshipsParts(); //Creates and manages collection of Ships.
                IValueGenerator valueGenerator = new ValueGenerator();
                BattleshipsSetup GameSetup = new BattleshipsSetup(board, parts, valueGenerator); //Creates and manages inteactions between Game Board and Game Parts.

                ITextIO textIO = new ConsoleIO(); //Manages Console Based Interfaces
                IInputHandler inputHandler = new InputHandler(); //Creates and manages input validation and conversion.
                IOutputGenerator output = new OutputGenerator(); //Creates and manages output construction.

                // Run Game


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