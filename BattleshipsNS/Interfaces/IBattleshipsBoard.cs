namespace BattleshipsNS
{
    public interface IBattleshipsBoard
    {
        int BoardSize { get; }
        IBoardSpace[,] PlayGrid { get; }
    }
}