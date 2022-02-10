namespace BattleshipsNS
{
    public interface IOutputGenerator
    {
        string GenerateInputRequestMessage();
        string GenerateFeedbackMessage(int MessagesCode, int SunkShipCount);
        string GenerateGameUI(IBattleshipsBoard gameBoard);
    }
}