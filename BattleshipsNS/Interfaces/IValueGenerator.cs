namespace BattleshipsNS
{
    public interface IValueGenerator
    {
        int GetRandomInt(int limit);
        (int, int) GetRandomTuple(int leftLimit, int rightLimit);
    }
}