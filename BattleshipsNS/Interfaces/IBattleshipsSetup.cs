namespace BattleshipsNS
{
    public interface IBattleshipsSetup
    {
        GameBoard GameBoard { get; }
        GameParts GameParts { get; }
    }
}