namespace BattleshipsNS
{
    public interface IShip
    {
        ShipTypes Type { get; }
        int Length { get; }
        bool Sunk { get; }
        bool Placed { get; }
        BoardSpace[] Sections { get; }
        int Orientation { get; set; }
        (int, int) StartLocation { get; set; }
        void PlaceShip(GameBoard gameBoard);
        void UpdateSunk();
    }
}