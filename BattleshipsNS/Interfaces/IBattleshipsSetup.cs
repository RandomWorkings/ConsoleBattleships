namespace BattleshipsNS
{
    public interface IBattleshipsSetup
    {
        IBattleshipsBoard GameBoard { get; }
        IBattleshipsParts GameParts { get; }
        IValueGenerator ValueGenerator { get; }
        void GenerateGame();
    }
}