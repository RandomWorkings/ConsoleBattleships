namespace BattleshipsNS
{
    public enum ShipTypes
    {
        Battleship,
        Destroyer,
    };

    public class Ship : IShip
    {
        public ShipTypes Type { get; private set; } = ShipTypes.Battleship;
        public int Length { get; private set; } = 0;
        public bool Sunk { get; set; } = false;
        public bool Placed { get; set; } = false;
        public IBoardSpace[] Sections { get; private set; }
        public int Orientation { get; set; } = 1;
        public (int row, int col) StartLocation { get; set; } = (0, 0);

        public Ship()
        {
            Sections = new IBoardSpace[Length];
        }

        public Ship(ShipTypes shipType)
        {
            Type = shipType;

            switch (Type)
            {
                case ShipTypes.Battleship:
                    Length = 5;
                    break;
                case ShipTypes.Destroyer:
                    Length = 4;
                    break;
                default:
                    break;
            }

            Sections = new IBoardSpace[Length];
        }
    }
}