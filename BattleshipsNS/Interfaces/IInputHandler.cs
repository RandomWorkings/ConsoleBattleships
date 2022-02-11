namespace BattleshipsNS
{
    public interface IInputHandler
    {
        Messages ValidateInput(string userInput);
        (int row, int col) ConvertInputToTuple(string userInput);
    }
}
