using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ShipRosterTests
    {
        //Shared Test Inputs
        private static readonly ShipTypes[] TestRoster = { ShipTypes.Battleship, ShipTypes.Destroyer };
        private static readonly int TestArrayLength = TestRoster.Length;
        private static readonly int TestGridSize = 10;

        [TestMethod]
        public void ShipRoster_WhenCalled_WithValidInputs_SetsShipsArray()
        {
            //Arrange
            int expectedSize = TestArrayLength;
            ShipRoster roster = new ShipRoster(TestRoster);

            //Act
            int actualSize = roster.Ships.Length;

            //Assess
            Assert.AreEqual(expectedSize, actualSize, "ShipRosterTests_ShipRoster : Array incorrect size");
            for (int i = 0; i < actualSize; i++)
            {
                Assert.IsInstanceOfType((roster.Ships[i]), typeof(Ship), "ShipRosterTests_ShipRoster : Array contents incorrect type");
            }
        }

        [TestMethod]
        public void CheckRosterSunk_WhenCalled_WithUnSunkShips_SetSunkFlag()
        {
            bool expected = false;
            ShipRoster roster = new ShipRoster(TestRoster);
            Grid grid = new Grid(TestGridSize);
            foreach (Ship ship in roster.Ships)
            {
                ship.PlaceShip(grid);
            }

            bool actual = roster.CheckRosterSunk();

            Assert.AreEqual(expected, actual, "ShipRosterTests_CheckSunkFlag : Flag in incorrect state");
        }

        [TestMethod]
        public void CheckRosterSunk_WhenCalled_WithAllShipsSunk_SetSunkFlag()
        {
            bool expected = true;
            ShipRoster roster = new ShipRoster(TestRoster);

            Grid grid = new Grid(TestGridSize);
            foreach (Ship ship in roster.Ships)
            {
                ship.PlaceShip(grid);
            }

            for (int i = 0; i < roster.Ships.Length; i++)
            {
                Ship ship = roster.Ships[i];
                for (int j = 0; j < ship.Sections.Length; j++)
                {
                    GridCell cell = ship.Sections[j];
                    cell.Contents='x';
                }
            }

            bool actual = roster.CheckRosterSunk();

            Assert.AreEqual(expected, actual, "ShipRosterTests_CheckSunkFlag : Flag in incorrect state");
        }

    }
}
