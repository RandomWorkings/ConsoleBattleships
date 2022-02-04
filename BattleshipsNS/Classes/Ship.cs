using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{

    public class Ship : IShip
    {
        public ShipTypes Type { get; private set; } = ShipTypes.Battleship;
        public int Length { get; private set; } = 4;
        public bool SunkFlag { get; private set; } = false;
        public BoardSpace[] Sections { get; private set; }
        public int Orientation { get; set; } = 1;
        public (int, int) StartLocation { get; set; } = (0, 0);

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
            ValueGenerator generator = new ValueGenerator();
            bool clearSpace = true;
            while(true)
            {
                Orientation = generator.GetRandomOrientation();
                (int row, int column) = generator.GetRandomLocation(Orientation, Length, gameBoard.BoardSize);
                
                StartLocation = (row, column);
                int sectionColumn = column;
                int sectionRow = row;

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
                    
                    for(int i = 0; i < Length; i++)
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
    }
}
