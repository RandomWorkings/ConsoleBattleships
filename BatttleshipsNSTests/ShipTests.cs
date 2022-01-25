using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ShipTests
    {  
        [TestMethod]
        public void Ship_WhenCalled_UpdateNextShipNumber()
        {
            //Arrange
            int ShipCount = 3;
            string expected = "ship-4";

            //Act
            for (int i = 0; i < ShipCount; i++)
            {
                new Ship();
            }
            Ship TestShip = new Ship();

            //Assess
            string actual = TestShip.ID;
            Assert.AreEqual(expected, actual, false, "Ship ID is not Incremented Correctly");

        }
    }
}
