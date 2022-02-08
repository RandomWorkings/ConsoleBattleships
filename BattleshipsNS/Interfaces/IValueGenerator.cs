namespace BattleshipsNS
{
    public interface IValueGenerator
    {
        int GetRandomInt(int limitInclusive);
        (int, int) GetRandomTuple(int leftLimit, int rightLimit);
    }
}