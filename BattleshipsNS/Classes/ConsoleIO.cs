using System;

namespace BattleshipsNS
{
    public class ConsoleIO : ITextIO
    {
        public virtual void OutputText(string s)
        {
            Console.WriteLine(s);
        }
        public virtual string InputText()
        {
            return Console.ReadLine();
        }
    }
}
