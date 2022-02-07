namespace BattleshipsNS
{
    public interface IInputHandler
    {
        int ValidateInput(string userInput);
        (int, int) ConvertInputToTuple(string userInput);
    }
}
