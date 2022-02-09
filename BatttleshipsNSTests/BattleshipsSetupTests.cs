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
            BattleshipsGameSetup testSetup = new BattleshipsGameSetup();

            BattleshipsBoard actual = testSetup.GameBoard;

            Assert.IsNotNull(actual, "BattleshipsSetupTests_AGridIsCreated : Grid Not Created");
        }

        [TestMethod]
        public void BattleshipsSetupTests_GivenSetupWasCalled_WhenSetupEnds_ThenAllShipsArePlaced()
        {
            int expected = 0;
            BattleshipsGameSetup testSetup = new BattleshipsGameSetup();

            int actual = testSetup.GameParts.Ships.Count(Ship => Ship.Placed == false);

            Assert.AreEqual(expected, actual, "BattleshipsSetupTests_AllShipsArePlaced : Ships left unplaced");
        }

        [TestMethod]
        public void BattleshipsSetupTests_GivenSetupWasCalled_WithValidArguments_WhenSetupEnds_ThenAGridIsCreated()
        {
            int testBoardSize = 10;
            ShipTypes[] testShipsList = { ShipTypes.Battleship };
            BattleshipsGameSetup testSetup = new BattleshipsGameSetup(testBoardSize, testShipsList);

            BattleshipsBoard actual = testSetup.GameBoard;

            Assert.IsNotNull(actual, "BattleshipsSetupTests_AGridIsCreated : Grid Not Created");
        }

        [TestMethod]
        public void BattleshipsSetupTests_GivenSetupWasCalled_WithValidArguments_ThenAllShipsArePlaced()
        {
            int expected = 0;
            int testBoardSize = 10;
            ShipTypes[] testShipsList = { ShipTypes.Battleship };
            BattleshipsGameSetup testSetup = new BattleshipsGameSetup(testBoardSize, testShipsList);

            int actual = testSetup.GameParts.Ships.Count(Ship => Ship.Placed == false);

            Assert.AreEqual(expected, actual, "BattleshipsSetupTests_AllShipsArePlaced : Ships left unplaced");
        }
    }
}