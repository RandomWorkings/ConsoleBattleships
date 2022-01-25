using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ShipTests
    {  
        [TestMethod]
        public void Ship_WhenCalled_UpdatesNextShipNumber()
        {
            //Arrange
            int ShipCount = 2;
            string expected = "ship-3";

            //Act
            for (int i = 0; i < ShipCount; i++)
            {
                new Ship();
            }
            Ship TestShip = new Ship();

            //Assess
            string actual = TestShip.ID;
            // areEqual - expected, actual, case-insensitive, fail message
            Assert.AreEqual(expected, actual, true, "Ship ID is not Incremented Correctly");
        }
    }
}
