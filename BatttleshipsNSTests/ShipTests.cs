using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ShipTests
    {  
        [TestMethod]
        public void Ship_WhenCalled_UpdatesNextShipNumberAndLength()
        {
            //Arrange
            string[] roster = {"Battleship", "Destroyer", "Battleship" };
            string expectedID = "Battleship - s3";
            int expectedLength = 4;

            //Act
            for (int i = 0; i < roster.Length-1; i++)
            {
                new Ship(roster[i], i+1);
            }

            Ship TestShip = new Ship(roster[roster.Length-1], roster.Length);

            //Assess
            string actualID = TestShip.ID;
            Assert.AreEqual(expectedID, actualID, true, "Ship Tests - Ship - ID is not incremented correctly");

            int actualLength = TestShip.Length;
            Assert.AreEqual(expectedLength, actualLength, "Ship Tests - Ship - Length is not assigned correctly");
        }

        public void Orientation__WhenInputIsValid_ShouldSet()
        {
            //Arrange

            //Act

            //Assess
            //Assert.AreEqual(expectedID, actualID, true, "MEthod is not Working Correctly");
        }
        public void StartLocation_WhenInputIsValid_ShouldSet()
        {
            //Arrange

            //Act

            //Assess
            //Assert.AreEqual(expectedID, actualID, true, "MEthod is not Working Correctly");
        }

        public void PlaceShip_WithValidInput_UpdatesSectionContents()
        {
            //Arrange
            Ship TestShip = new Ship("Battleship", 1);
            Grid refGrid = new Grid(10, TestShip);

            ship.PlaceShip(refGrid);

            //Act

            //Assess
            //Assert.AreEqual(expected, actual, true, "Ship ID is not Incremented Correctly");
        }


        public void UpdateSunkFlag_WithAllSectionGridCellsContentsNotNull_UpdatesSunkFlag()
        {
            //Arrange
            
            //Act
            
            //Assess
            //Assert.AreEqual(expected, actual, true, "Ship ID is not Incremented Correctly");
        }

    }
}
