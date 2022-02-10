namespace BattleshipsNS
{
    public interface IShip
    {
        ShipTypes Type { get; }
        int Length { get; }
        bool Sunk { get; }
        bool Placed { get; }
        IBoardSpace[] Sections { get; }
        int Orientation { get; set; }
        (int, int) StartLocation { get; set; }
        void PlaceShip(IGameBoard gameBoard);
        void UpdateSunk();
    }
}