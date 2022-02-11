namespace BattleshipsNS
{
    public interface IInputHandler
    {
        Messages ValidateInput(string userInput);
        (int, int) ConvertInputToTuple(string userInput);
    }
}
