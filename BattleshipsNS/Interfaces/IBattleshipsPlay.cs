namespace BattleshipsNS
{
    public interface IBattleshipsPlay
    {
        BattleshipsParts GameParts { get; }
        BattleshipsBoard GameBoard { get; }
    }
}