namespace BattleshipsNS
{
    public interface IBoardSpace
    {
        bool Occupied { get; set; }
        char? Contents { get; set; }
    }
}