namespace BattleshipsNS
{
    public interface IGameParts
    {
        Ship[] Ships { get; }
        int ShipCount { get; }
        int UpdateShipCount();
    }
}