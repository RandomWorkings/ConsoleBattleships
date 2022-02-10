namespace BattleshipsNS
{
    public interface IOutputGenerator
    {
        string GenerateInputRequest();
        string GenerateMessages(int MessagesCode, int SunkShipCount);
        string GeneratePlayGridUI(BattleshipsBoard playGrid);
    }
}