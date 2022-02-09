using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;
using System.Linq;

namespace BattleshipsNSTests
{
    [TestClass]
    public class BattleshipsSetupTests
    {
        [TestMethod]
        public void BattleshipsSetupTests_GivenSetupWasCalled_WhenSetupEnds_ThenAGridIsCreated()
        {
            BattleshipsSetup testSetup = new BattleshipsSetup();

            GameBoard actual = testSetup.GameBoard;

            Assert.IsNotNull(actual, "BattleshipsSetupTests_AGridIsCreated : Grid Not Created");
        }

        [TestMethod]
        public void BattleshipsSetupTests_GivenSetupWasCalled_WhenSetupEnds_ThenAllShipsArePlaced()
        {
            int expected = 0;
            BattleshipsSetup testSetup = new BattleshipsSetup();

            int actual = testSetup.GameParts.Ships.Count(Ship => Ship.Placed == false);

            Assert.AreEqual(expected, actual, "BattleshipsSetupTests_AllShipsArePlaced : Ships left unplaced");
        }
    }
}