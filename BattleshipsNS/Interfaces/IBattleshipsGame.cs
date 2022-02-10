namespace BattleshipsNS
{
    public interface IBattleshipsGame
    {
        IBattleshipsBoard Board { get; }
        IBattleshipsParts Parts { get; }
        ITextIO TextIO { get; }
        IInputHandler InputHandler { get; }
        IOutputGenerator OutputGenerator { get; }
        void RunGame();
    }
}