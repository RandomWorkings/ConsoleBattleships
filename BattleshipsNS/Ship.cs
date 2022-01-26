﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    
    public class Ship : IShip
    {
        // Fields, Properties
        public string ID { get; private set; }
        public ShipTypes Type { get; private set; }
        public int Length { get; private set; }
        public bool SunkFlag { get; private set; }
        public int Orientation { get; set; }
        public (int, int) StartLocation { get; set; }
        public GridCell[] Sections { get; private set; }

        // Constructor Declaration of Class
        public Ship(ShipTypes ship, int shipCount)
		{
            ID = ship + " - s" + shipCount;

            Type = ship;

            Length = (int)Type;

            SunkFlag = false;

            Orientation = 1;

            StartLocation = (0, 0);

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
                (int row, int column) = generator.GetRandomLocation(Orientation, Length, refGrid.Size);
                
                StartLocation = (row, column);
                int sectionColumn = column;
                int sectionRow = row;

                switch (Orientation)
                {
                    case 2: //Vertical
                        
                        for (int v = 0; v < Length; v++)
                        {
                            GridCell refCell = refGrid.PlayGrid[sectionRow, sectionColumn];
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
                            GridCell refCell = refGrid.PlayGrid[sectionRow, sectionColumn];
                            
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
            foreach (GridCell section in Sections)
            {
                switch (section.Contents)
                { 
                    case null:
                        SunkFlag = false;
                        break;

                    default:
                        SunkFlag = true;
                        break;
                }
            }

        }
        
    }
}
