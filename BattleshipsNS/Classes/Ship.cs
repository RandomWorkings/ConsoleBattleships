namespace BattleshipsNS
{
    public enum ShipTypes
    {
        Battleship = 5,
        Destroyer = 4
    };

    public enum ShipOrientations
    {
        Horizontal,
        Vertical
    };

    public class Ship : IShip
    {
        public ShipTypes Type { get; private set; } = ShipTypes.Battleship;
        public int Length { get; private set; } = 4;
        public bool Sunk { get; set; } = false;
        public bool Placed { get; set; } = false;
        public IBoardSpace[] Sections { get; private set; }
        public int Orientation { get; set; } = (int) ShipOrientations.Horizontal;
        public (int, int) StartLocation { get; set; } = (0, 0);

        public Ship()
        {
            Sections = new IBoardSpace[Length];
        }

        public Ship(ShipTypes shipType)
        {
            Type = shipType;
            Length = (int)Type;
            Sections = new IBoardSpace[Length];
        }
    }
}