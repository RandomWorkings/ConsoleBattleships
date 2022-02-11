namespace BattleshipsNS
{
    public interface IShip
    {
        ShipTypes Type { get; }
        int Length { get; }
        bool Sunk { get; set; }
        bool Placed { get; set; }
        IBoardSpace[] Sections { get; }
        int Orientation { get; set; }
        (int row, int col) StartLocation { get; set; }
    }
}