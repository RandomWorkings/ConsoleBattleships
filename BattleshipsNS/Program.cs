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
            InputHandler Inputs = new InputHandler();
            OutputHandler Outputs = new OutputHandler();
            BattleshipsSetup GameSetup = new BattleshipsSetup();

            bool Running = true;
            //Program Loop
            while (Running)
            {
                new BattleshipsPlay(GameSetup.GameBoard, GameSetup.GameParts, Inputs, Outputs);

                //Repeat Program Option
                Console.WriteLine();
                Console.WriteLine("The Program Battleships has finished!");
                Console.WriteLine("Press Enter to repeat program");
                Console.WriteLine("Press any other button to quit");
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
