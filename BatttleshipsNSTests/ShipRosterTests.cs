using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ShipRosterTests
    {
        //Shared Test Inputs

        [TestMethod]
        public void ShipRoster_WithArrayofShipNames_CreatesAnArrayofShips()
        {
            //Arrange
            int expectedArraySize = 2;
            string[] roster = { "Battleship", "Destroyer" };

            //Act
            Ship[] Roster = new Ship[roster.Length];
            for (int i = 0; i < roster.Length; i++)
            {
                Roster[i] = new Ship(roster[i], i+1);
            }

            //Assess
            Assert.AreEqual(expectedArraySize, Roster.Length, "Ship Roster Tests - Ship Roster - Array incorrect size");
            for (int i = 0; i < roster.Length; i++)
            {
                Assert.IsInstanceOfType((Roster[i]), typeof(Ship), "Ship Roster Tests - Ship Roster - Array contents incorrect type");
            }
        }

        [TestMethod]
        public void CheckRosterSunk_WhenCalled_WithAllShipsSunk_SetSunkFlag()
        {
            //Arrange

            //Act

            //Assess
        }

        public void CheckRosterSunk_WhenCalled_WithAllShipsUnSunk_SetSunkFlag()
        {
            //Arrange

            //Act

            //Assess

        }

    }
}
