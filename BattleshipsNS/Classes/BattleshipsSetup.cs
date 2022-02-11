namespace BattleshipsNS
{
    public class BattleshipsSetup : IBattleshipsSetup
    {
        public IBattleshipsBoard GameBoard { get; private set; }
        public IBattleshipsParts GameParts { get; private set; }
        public IValueGenerator ValueGenerator { get; private set; }

        public BattleshipsSetup(IBattleshipsBoard board, IBattleshipsParts parts, IValueGenerator valueGenerator)
        {
            GameBoard = board;
            GameParts = parts;
            ValueGenerator = valueGenerator;
        }

        public void RunSetup()
        {
            foreach (IShip ship in GameParts.Ships)
            {
                PlaceShip(ship);
            }
        }

        private void PlaceShip(IShip ship)
        {
            bool allSpacesClear = true;

            while (!ship.Placed)
            {
                ship.Orientation = GenerateOrientation();
                ship.StartLocation = GenerateStartLocation(ship);

                //int sectionRow = ship.StartLocation.Item1;
                int sectionRow = ship.StartLocation.row;
                int sectionColumn = ship.StartLocation.col;

                // Link Ship Sections to Game Board Spaces, and check if occupied.
                for (int section = 0; section < ship.Length; section++)
                {
                    IBoardSpace refCell = GameBoard.PlayGrid[sectionRow, sectionColumn];
                    if (refCell.Occupied)
                    {
                        allSpacesClear = false;
                        break;
                    }

                    ship.Sections[section] = refCell;

                    switch (ship.Orientation)
                    {
                        case (int)ShipOrientations.Vertical:
                            {
                                sectionRow++;
                                break;
                            }
                        default:// Horizontal
                            {
                                sectionColumn++;
                                break;
                            }
                    }
                }

                // Place ship, and updated board spaces.
                if (allSpacesClear)
                {
                    for (int i = 0; i < ship.Length; i++)
                    {
                        ship.Sections[i].Occupied = true;
                    }
                    ship.Placed = true;
                }
            }
        }

        private int GenerateOrientation()
        {
            int orientationOptionsCount = ShipOrientations.GetNames(typeof(ShipOrientations)).Length;
            int generatedOrientation = ValueGenerator.GetRandomInt(orientationOptionsCount);
            return generatedOrientation;
        }

        private (int, int) GenerateStartLocation(IShip ship)
        {
            int shipLength = ship.Length;
            int shipOrientation = ship.Orientation;
            int columnLimit;
            int rowLimit;

            switch (shipOrientation)
            {
                case (int)ShipOrientations.Vertical: //Limit Rows
                    columnLimit = GameBoard.BoardSize;
                    rowLimit = GameBoard.BoardSize - shipLength;
                    break;

                default: // Horizontal, Limit Columns
                    columnLimit = GameBoard.BoardSize - shipLength;
                    rowLimit = GameBoard.BoardSize;
                    break;
            }

            (int, int) generatedStartLocation = ValueGenerator.GetRandomTuple(rowLimit, columnLimit);
            return generatedStartLocation;
        }
    }
}