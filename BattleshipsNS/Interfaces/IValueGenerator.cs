namespace BattleshipsNS
{
    public interface IValueGenerator
    {
        int GetRandomInt();
        (int, int) GetRandomTuple();
    }
}