namespace BattleshipsNS
{
    public interface IGameBoard
    {
        int BoardSize { get; }
        BoardSpace[,] PlayGrid { get; }

    }
}