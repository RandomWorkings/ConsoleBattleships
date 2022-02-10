﻿using System.Linq;
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
        Horizontal,
        Vertical
    };

    public class Ship : IShip
    {
        public ShipTypes Type { get; private set; } = ShipTypes.Battleship;
        public int Length { get; private set; } = 4;
        public bool Sunk { get; private set; } = false;
        public bool Placed { get; private set; } = false;
        public IBoardSpace[] Sections { get; private set; }
        public int Orientation { get; set; } = 1;
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

        public void PlaceShip(IGameBoard gameBoard, IValueGenerator valueGenerator)
        {
            bool allSpacesClear = true;

            while (!Placed)
            {
                GenerateOrientation(valueGenerator);
                GenerateStartLocation(valueGenerator, gameBoard.BoardSize);

                int sectionRow = StartLocation.Item1;
                int sectionColumn = StartLocation.Item2;

                // Link Ship Sections to Game Board Spaces, and check if occupied.
                for (int section = 0; section < Length; section++)
                {
                    IBoardSpace refCell = gameBoard.PlayGrid[sectionRow, sectionColumn];
                    if (refCell.Occupied)
                    {
                        allSpacesClear = false;
                        break;
                    }

                    Sections[section] = refCell;

                    switch (Orientation)
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
                    for (int i = 0; i < Length; i++)
                    {
                        Sections[i].Occupied = true;
                    }
                    Placed = true;
                }
            }
        }

        public void UpdateSunk()
        {
            int sunkSections = 0;

            if (!Sunk)
            {
                sunkSections = Sections.Count(section => section.Contents == 'x'); // x indicates a targeted and occupied location.

                if (sunkSections == Length)
                {
                    Sunk = true;
                }
            }
        }

        private void GenerateOrientation(IValueGenerator valueGenerator)
        {
            int orientationOptionsCount = Enum.GetNames(typeof(ShipOrientations)).Length;
            int generatedOrientation = valueGenerator.GetRandomInt(orientationOptionsCount);
            Orientation = generatedOrientation;
        }

        private void GenerateStartLocation(IValueGenerator valueGenerator, int boardSize)
        {
            int columnLimit;
            int rowLimit;

            switch (Orientation)
            {
                case (int)ShipOrientations.Vertical: //Limit Rows
                    columnLimit = boardSize;
                    rowLimit = boardSize - Length;
                    break;

                default: // Horizontal, Limit Columns
                    columnLimit = boardSize - Length;
                    rowLimit = boardSize;
                    break;
            }

            StartLocation = valueGenerator.GetRandomTuple(rowLimit, columnLimit);
        }
    }
}