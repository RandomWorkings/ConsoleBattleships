namespace BattleshipsNS
{
    public interface IBattleshipsSetup
    {
        IGameBoard GameBoard { get; }
        IGameParts GameParts { get; }
        IValueGenerator ValueGenerator { get; }
        void GenerateGame();
    }
}