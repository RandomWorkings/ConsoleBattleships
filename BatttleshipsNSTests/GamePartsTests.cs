using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class GamePartsTests
    {
        //Shared Test Inputs
        private static readonly ShipTypes[] TestShipList = { ShipTypes.Battleship, ShipTypes.Destroyer };
        private static readonly int TestArrayLength = TestShipList.Length;
//        private static readonly int TestGridSize = 10;

        [TestMethod]
        public void Ships_WhenCalled_WithValidInputs_SetsShipsArray()
        {
            //Arrange
            int expectedSize = TestArrayLength;
            GameParts roster = new GameParts(TestShipList);

            //Act
            int actualSize = roster.Ships.Length;

            //Assess
            Assert.AreEqual(expectedSize, actualSize, ($@"ShipRosterTests_ShipRoster : Array incorrect size"));
            for (int i = 0; i < actualSize; i++)
            {
                Assert.IsInstanceOfType((roster.Ships[i]), typeof(Ship), ($@"ShipRosterTests_ShipRoster : Array contents incorrect type"));
            }
        }
/*
        [TestMethod]
        public void CheckAllShipsSunk_WhenCalled_WithUnSunkShips_SetSunkFlag()
        {
            bool expected = false;
            GameParts roster = new GameParts(TestShipList);
            GameBoard grid = new GameBoard(TestGridSize);
            foreach (Ship ship in roster.Ships)
            {
                ship.PlaceShip(grid);
            }

            bool actual = roster.CheckAllShipsSunk();

            Assert.AreEqual(expected, actual, ($@"ShipRosterTests_CheckSunkFlag : Flag in incorrect state"));
        }

        [TestMethod]
        public void CheckRosterSunk_WhenCalled_WithAllShipsSunk_SetSunkFlag()
        {
            bool expected = true;
            GameParts roster = new GameParts(TestShipList);

            GameBoard grid = new GameBoard(TestGridSize);
            foreach (Ship ship in roster.Ships)
            {
                ship.PlaceShip(grid);
            }

            for (int i = 0; i < roster.Ships.Length; i++)
            {
                Ship ship = roster.Ships[i];
                for (int j = 0; j < ship.Sections.Length; j++)
                {
                    BoardSpace cell = ship.Sections[j];
                    cell.Contents='x';
                }
            }

            bool actual = roster.CheckAllShipsSunk();

            Assert.AreEqual(expected, actual, ($@"ShipRosterTests_CheckSunkFlag : Flag in incorrect state"));
        }
*/
    }
}
