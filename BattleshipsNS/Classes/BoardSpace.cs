namespace BattleshipsNS
{
    public class BoardSpace : IBoardSpace
    {
        public bool Occupied { get; set; } = false;
        public char? Contents { get; set; } = null;
    }
}