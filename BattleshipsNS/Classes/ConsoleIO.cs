using System;

namespace BattleshipsNS
{
    public class ConsoleIO : IConsoleIO
    {
        public virtual void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
        public virtual string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
