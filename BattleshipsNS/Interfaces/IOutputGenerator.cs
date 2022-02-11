namespace BattleshipsNS
{
    public interface IOutputGenerator
    {
        string GenerateInputRequestMessage();
        string GenerateFeedbackMessage(Messages MessageSwitch, int SunkShipCount);
        string GenerateGameUI(IBattleshipsBoard gameBoard);
    }
}