namespace BattleshipsNS
{
    public interface IGameParts
    {
        IShip[] Ships { get; }
        int ShipCount { get; }
        int UpdateShipCount();
    }
}