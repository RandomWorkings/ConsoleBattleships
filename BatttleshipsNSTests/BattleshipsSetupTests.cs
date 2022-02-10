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

            BattleshipsBoard actual = testSetup.GameBoard;

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

        [TestMethod]
        public void BattleshipsSetupTests_GivenSetupWasCalled_WithValidArguments_WhenSetupEnds_ThenAGridIsCreated()
        {
            int testBoardSize = 10;
            ShipTypes[] testShipsList = { ShipTypes.Battleship };
            BattleshipsSetup testSetup = new BattleshipsSetup(testBoardSize, testShipsList);

            BattleshipsBoard actual = testSetup.GameBoard;

            Assert.IsNotNull(actual, "BattleshipsSetupTests_AGridIsCreated : Grid Not Created");
        }

        [TestMethod]
        public void BattleshipsSetupTests_GivenSetupWasCalled_WithValidArguments_ThenAllShipsArePlaced()
        {
            int expected = 0;
            int testBoardSize = 10;
            ShipTypes[] testShipsList = { ShipTypes.Battleship };
            BattleshipsSetup testSetup = new BattleshipsSetup(testBoardSize, testShipsList);

            int actual = testSetup.GameParts.Ships.Count(Ship => Ship.Placed == false);

            Assert.AreEqual(expected, actual, "BattleshipsSetupTests_AllShipsArePlaced : Ships left unplaced");
        }

        public void PlaceShip_WhenCalled_WithValidArguments_SetPlaced()
        {
            bool expected = true;
            int testSize = (int)ShipTypes.Battleship; //Enum associated value, the length of the ship
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);
            BattleshipsBoard testBoard = new BattleshipsBoard(testSize);
            testShip.PlaceShip(testBoard);

            bool actual = testShip.Placed;

            Assert.AreEqual(expected, actual, ($@"ShipTests_PlaceShip : ship not placed."));
        }


        [TestMethod]
        public void PlaceShip_WhenCalled_WithValidArguments_SetSectionContent()
        {
            int testSize = (int)ShipTypes.Battleship; //Enum associated value, the length of the ship
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);
            BattleshipsBoard testBoard = new BattleshipsBoard(testSize);

            testShip.PlaceShip(testBoard);

            Assert.IsNotNull(testShip.Sections[0], ($@"ShipTests_PlaceShip : Incorrect section assignment."));
        }

        [TestMethod]
        public void PlaceShip_WhenCalled_WithValidArguments_SetsValidStartLocation()
        {
            // On a 4 by 4 grid the length 4 battleship can only start on play grid [0, 0].
            bool expected = true;
            int testSize = (int)ShipTypes.Battleship;  //Enum associated value, the length of the ship
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);
            BattleshipsBoard testBoard = new BattleshipsBoard(testSize);

            testShip.PlaceShip(testBoard);
            bool actual = testShip.Sections[0].Occupied;

            Assert.AreEqual(expected, actual, ($@"ShipTests_PlaceShip : Incorrect section assignment."));
        }
    }
}