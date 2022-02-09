namespace ProgramNS
{
    public interface IValueGenerators
    {
    }

    public interface IRandomGenerator : IValueGenerators
    {
        int GetRandomInt(int limit);
        (int, int) GetRandomTuple(int leftLimit, int rightLimit);
    }

}