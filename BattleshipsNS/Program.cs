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
        public enum ShipType
        {
            Battleship = 4,
            Destroyer = 3
        };

        static void Main(string[] args)
        {

            //Console Hold-Open Message
            Console.WriteLine("Program Finished. Press any Key to Close...");
            System.Console.ReadLine();
        }
    }
}
