using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class BoardSpace : IBoardSpace
    {
        public string ID { get; private set; }
        public bool Occupied { get; set; }
        public char? Contents { get; set; }

        public BoardSpace()
        {
            ID = "A1";
            Occupied = false;
            Contents = null;
        }

        public BoardSpace(int row, int column)
        {
            IDGenerator(row, column);
            Occupied = false;
            Contents = null;
        }

        private void IDGenerator(int row, int column)
        {
            char StartingLetter = 'A';
            // Adjust to match column;
            int LetterAdjustment = 0 + column;
            char CurrentLetter = (Char)(Convert.ToInt32(StartingLetter) + LetterAdjustment);

            ID = ""+CurrentLetter + row + "";            
        }

    }
}
