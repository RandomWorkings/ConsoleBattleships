using System.Linq;
using System;

namespace BattleshipsNS
{
    public enum ShipTypes
    {
        Battleship = 5,
        Destroyer = 4
    };

    public enum ShipOrientations
    {
        Horizontal = 1,
        Vertical
    };

    public class Ship : IShip
    {
        public ShipTypes Type { get; private set; } = ShipTypes.Battleship;
        public int Length { get; private set; } = 4;
        public bool SunkFlag { get; private set; } = false;
        public BoardSpace[] Sections { get; private set; }
        public int Orientation { get; set; } = 1;
        public (int, int) StartLocation { get; set; } = (0, 0);
        public ValueGenerator generator = new ValueGenerator();

        public Ship(ShipTypes shipType)
        {
            Type = shipType;

            Length = (int)Type;

            Sections = new BoardSpace[Length];

            for (int s = 0; s < Length; s++)
            {
                Sections[s] = new BoardSpace();
            }
        }

        public void PlaceShip(GameBoard gameBoard)
        {
            
            bool clearSpace = true;

            while (true)
            {
                GenerateOrientation();
                GenerateStartLocation(gameBoard.BoardSize);

                int sectionRow = StartLocation.Item1;
                int sectionColumn = StartLocation.Item2;

                switch (Orientation)
                {
                    case 2: //Vertical

                        for (int v = 0; v < Length; v++)
                        {
                            BoardSpace refCell = gameBoard.PlayGrid[sectionRow, sectionColumn];
                            if (refCell.Occupied)
                            {
                                clearSpace = false;
                                break;
                            }
                            Sections[v] = refCell;
                            clearSpace = true;
                            sectionRow++;
                        }
                        break;

                    default: // Horizontal
                        for (int h = 0; h < Length; h++)
                        {
                            BoardSpace refCell = gameBoard.PlayGrid[sectionRow, sectionColumn];

                            if (refCell.Occupied)
                            {
                                clearSpace = false;
                                break;
                            }
                            Sections[h] = refCell;
                            clearSpace = true;
                            sectionColumn++;
                        }
                        break;
                }

                //Loop breaker
                if (clearSpace)
                {
                    for (int i = 0; i < Length; i++)
                    {
                        Sections[i].Occupied = true;
                    }
                    break;
                }
            }
        }

        public void UpdateSunkFlag()
        {
            int sunkSections = 0;

            if (!SunkFlag)
            {
                sunkSections = Sections.Count(section => section.Contents == 'x');

                if (sunkSections == Length)
                {
                    SunkFlag = true;
                }
            }
        }

        private void GenerateOrientation()
        {
            int orientationOptionsCount = Enum.GetNames(typeof(ShipOrientations)).Length;
            Orientation = generator.GetRandomInt(orientationOptionsCount);           
        }

        private void GenerateStartLocation(int boardSize)
        {
            int columnLimit;
            int rowLimit;

            switch (Orientation)
            {
                case 2: //Vertical, Limit Rows
                    columnLimit = boardSize;
                    rowLimit = boardSize - Length;
                    break;

                default: // Horizontal, Limit Columns
                    columnLimit = boardSize - Length;
                    rowLimit = boardSize;
                    break;
            }

            StartLocation = generator.GetRandomTuple(rowLimit, columnLimit);
        }
    }
}