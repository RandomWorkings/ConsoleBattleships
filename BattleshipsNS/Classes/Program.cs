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
                Console.WriteLine();
                BattleshipsSetup GameSetup = new BattleshipsSetup();            
                new BattleshipsPlay(GameSetup.GameBoard, GameSetup.GameParts);

                //Repeat Program Option
                Console.WriteLine();
                Console.WriteLine("\tThe Program Battleships has finished!");
                Console.WriteLine("\tPress Enter to repeat program");
                Console.WriteLine("\tPress any other button to quit");
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
