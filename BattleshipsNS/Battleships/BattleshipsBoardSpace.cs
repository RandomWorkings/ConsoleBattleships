namespace BattleshipsNS
{
    public class BattleshipsBoardSpace : IBattleshipsBoardSpace
    {
        public bool Occupied { get; set; } = false;
        public char? Contents { get; set; } = null;
    }
}