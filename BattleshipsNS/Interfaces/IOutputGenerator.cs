namespace BattleshipsNS
{
    public interface IOutputGenerator
    {
        string GenerateMessages(int MessagesCode, int SunkShipCount);

        string GeneratePlayGrid(GameBoard playGrid);
    }
}