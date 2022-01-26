using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public enum ShipTypes
    {
        Battleship = 4,
        Destroyer = 3
    };

    public class Ship : IShip
    {
        // Fields, Properties
        public string ID { get; private set; }
        public int Length { get; private set; }
        public bool SunkFlag { get; private set; }
        public int Orientation { get; set; }
        public (int, int) StartLocation { get; set; }
        public GridCell[] Sections { get; private set; }

        // Constructor Declaration of Class
        public Ship(string ship, int shipCount)
		{
            ID = ship + " - s" + shipCount;

            ShipTypes shipType = (ShipTypes)Enum.Parse(typeof(ShipTypes), ship);

            Length = (int)shipType;

            SunkFlag = false;

            Sections = new GridCell[Length];
        }

        // Methods, Events, Operators
        public void PlaceShip(Grid refGrid)
        {
            ValueGenerator generator = new ValueGenerator();
            bool clearSpace = true;

            while(true)
            {
                Orientation = generator.GetRandomOrientation();
                (int column, int row) = generator.GetRandomLocation(refGrid.Size);

                StartLocation = (column, row);
                int sectionColumn = column;
                int sectionRow = row;


                switch (Orientation)
                {
                    case 2: //Vertical
                        for (int i = 0; i < Sections.Length; i++)
                        {
                            if (refGrid.PlayGrid[sectionColumn, sectionRow].Occupied)
                            {
                                clearSpace = false;
                                break;
                            }
                            Sections[i] = refGrid.PlayGrid[sectionColumn, sectionRow];
                            clearSpace = true;

                            sectionRow++;
                            
                        }
                        break;

                    default: // Horizontal
                        for (int i = 0; i < Sections.Length; i++)
                        {
                            if (refGrid.PlayGrid[sectionColumn, sectionRow].Occupied)
                            {
                                clearSpace = false;
                                break;
                            }
                            Sections[i] = refGrid.PlayGrid[sectionColumn, sectionRow];
                            clearSpace = true;

                            sectionColumn++;
                        }
                        break;
                }

                //Loop breaker
                if(clearSpace)
                { break; }

            }

        }
       
            
        public void UpdateSunkFlag()
        { }
        
    }
}
