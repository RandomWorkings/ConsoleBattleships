namespace BattleshipsNS
{
    public interface IBattleshipsSetup
    {
        GameParts GameParts { get; }
        GameBoard GameBoard { get; }
    }
}