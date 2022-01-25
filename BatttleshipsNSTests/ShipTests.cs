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
            int ShipCount = 2;
            string expectedID = "ship-3";

            //Act
            for (int i = 0; i < ShipCount; i++)
            {
                new Ship();
            }
            Ship TestShip = new Ship();

            //Assess
            string actualID = TestShip.ID;
            Assert.AreEqual(expectedID, actualID, true, "Ship ID is not Incremented Correctly");
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

        public void UpdateSectionLocationsip_WithSetOrientationAndStartLocation_UpdatesSectionContents()
        {
            //Arrange
            
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
