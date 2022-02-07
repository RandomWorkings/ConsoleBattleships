namespace BattleshipsNS
{
    public interface IOutputGenerator
    {
        string GenerateMessages(int MessagesCode, int SunkShipCount);

        string GeneratePlayGridUI(GameBoard playGrid);
    }
}