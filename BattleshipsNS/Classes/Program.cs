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

                //### MAIN PROGRAM STARTS HERE ###

                // Construct Parts
                IGameBoard board = new BattleshipsBoard();
                IGameComponents components = new BattleshipsShips();
                IGameInputHandler inputHandler = new BattleshipsInputHandler();
                IGameOutputGenerator outputGenerator = new BattleshipsOutputGenerator();
                ITextIO textIO = new ConsoleIO();
                IValueGenerators valueGenerator = new RandomGenerator();
                IGameSetup gameSetup = new GameSetup(board, components, valueGenerator);
                IGamePlay gamePlay = new GamePlay(gameSetup, textIO, inputHandler, outputGenerator);

                // Setup Game

                // Play Game

                // ### MAIN PROGRAM ENDS HERE ###

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