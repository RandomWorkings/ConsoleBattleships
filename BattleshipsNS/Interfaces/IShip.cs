namespace BattleshipsNS
{
    public interface IShip
    {
        ShipTypes Type { get; }
        int Length { get; }
        bool SunkFlag { get; }
        BoardSpace[] Sections { get; }
        int Orientation { get; set; }
        (int, int) StartLocation { get; set; }
        void PlaceShip(GameBoard gameBoard);
        void UpdateSunkFlag();
    }
}