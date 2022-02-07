namespace BattleshipsNS
{
    public interface IOutputHandler
    {
        void GenerateMessages(int MessagesCode, int SunkShipCount);

        void DisplayPlayGrid(GameBoard playGrid);
    }
}