namespace BattleshipsNS
{
    public interface IValueGenerator
    {
        int GetRandomOrientation();
        (int, int) GetRandomLocation(int shipOrientation, int shipLength, int boardSize);
    }
}