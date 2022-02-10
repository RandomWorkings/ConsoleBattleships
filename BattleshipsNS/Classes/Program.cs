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

                // Setup Game Elements
                IBattleshipsBoard board = new BattleshipsBoard(); //Creates and manages collection of BoardSpaces.
                IBattleshipsParts parts = new BattleshipsParts(); //Creates and manages collection of Ships.
                ITextIO textIO = new ConsoleIO(); //Manages Console based interfaces
                IInputHandler inputHandler = new InputHandler(board.BoardSize); //Creates and manages input validation and conversion.
                IOutputGenerator outputGenerator = new OutputGenerator(); //Creates and manages output construction.
                IValueGenerator valueGenerator = new ValueGenerator();

                // Setup Game
                IBattleshipsSetup gameSetup = new BattleshipsSetup(board, parts, valueGenerator); //Creates and manages inteactions between Game Board and Game Parts.
                gameSetup.RunSetup();
                IBattleshipsGame battleshipsGame = new BattleshipsGame(gameSetup, textIO, inputHandler, outputGenerator); //Creates and manages inteactions between User and game elements

                // Run Game
                battleshipsGame.RunGame();

                // NOT PART OF BATTLESHIPS GAME
                // Program Loop Control
                Console.WriteLine($"{Tab}The program has completed it's current run");
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