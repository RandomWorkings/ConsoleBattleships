namespace BattleshipsNS
{
    public interface IInputHandler
    {
        string GetUserInput();
        int ValidateInput(string userInput);
        (int, int) ConvertInputToTuple(string userInput);
    }
}
