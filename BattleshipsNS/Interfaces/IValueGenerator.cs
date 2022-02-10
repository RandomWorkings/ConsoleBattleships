namespace BattleshipsNS
{
    public interface IValueGenerator
    {
        int GetRandomInt();
        int GetRandomInt(int rangeLimit);
        (int, int) GetRandomTuple();
        (int, int) GetRandomTuple(int rangeLimitItem1, int rangeLimitItem2);
    }
}