using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ShipRosterTests
    {
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
        public void CheckRosterSunk_With_DoesSomething()
        {
            //Arrange

            //Act

            //Assess

        }
    }
}
