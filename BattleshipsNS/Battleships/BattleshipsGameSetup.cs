﻿namespace BattleshipsNS
{
    public class BattleshipsGameSetup : IBattleshipsGameSetup
    {
        public BattleshipsShips GameParts { get; private set; }
        public BattleshipsBoard GameBoard { get; private set; }
        private int BoardSize;
        private ShipTypes[] ShipsList;

        public BattleshipsGameSetup()
        {
            // Program Default settings


            // Create Game Components
            GameParts = new BattleshipsShips(ShipsList);
            GameBoard = new BattleshipsBoard(BoardSize);

            // Setup Game Components
            foreach (BattleshipsShip ship in GameParts.Ships)
            {
                ship.PlaceShip(GameBoard);
            }
        }

        public BattleshipsGameSetup(int boardSize, ShipTypes[] shipsList)
        {
            BoardSize = boardSize;
            ShipsList = shipsList;

            // Create Game Components
            GameParts = new BattleshipsShips(ShipsList);
            GameBoard = new BattleshipsBoard(BoardSize);

            // Setup Game Components
            foreach (BattleshipsShip ship in GameParts.Ships)
            {
                ship.PlaceShip(GameBoard);
            }
        }
    }
}