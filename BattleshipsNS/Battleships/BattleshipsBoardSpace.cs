using ProgramNS;
namespace BattleshipsNS
{
    public class BattleshipsBoardSpace : IBoardSpace
    {
        public bool Occupied { get; set; } = false;
        public char? Contents { get; set; } = null;
    }
}