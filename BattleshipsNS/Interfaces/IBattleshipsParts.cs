namespace BattleshipsNS
{
    public interface IBattleshipsParts
    {
        IShip[] Ships { get; }
        int ShipCount { get; }
        Messages UpdateShipCount();
    }
}