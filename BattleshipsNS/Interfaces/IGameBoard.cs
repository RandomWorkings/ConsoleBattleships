namespace BattleshipsNS
{
    public interface IGameBoard
    {
        int BoardSize { get; }
        IBoardSpace[,] PlayGrid { get; }
    }
}