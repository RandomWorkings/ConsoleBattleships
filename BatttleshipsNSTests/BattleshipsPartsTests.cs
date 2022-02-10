using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class BattleshipsPartsTests
    {
        [TestMethod]
        public void GameParts_WhenCalled_WithValidArguments_SetShipCount()
        {
            int expected = 1;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            BattleshipsParts testParts = new BattleshipsParts(testShipsList);

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"GamePartsTests_SetShipCount : Incorrect Ship Count value returned"));
        }

        [TestMethod]
        public void GameParts_WhenCalled_WithValidArguments_SetShipArrayLength()
        {
            int expected = 1;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            BattleshipsParts testParts = new BattleshipsParts(testShipsList);

            int actual = testParts.Ships.Length;

            Assert.AreEqual(expected, actual, ($@"GamePartsTests_SetShipArrayLength : Incorrect Ship Array Length value returned"));
        }

        [TestMethod]
        public void GameParts_WhenCalled_WithValidArguments_SetArrayContents()
        {
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            BattleshipsParts testParts = new BattleshipsParts(testShipsList);

            Ship actual = testParts.Ships[0];

            Assert.IsNotNull(actual, $@"GamePartsTests_SetArrayContent : No Array Contents exists");
        }

        [TestMethod]
        public void UpdateShipCount_WhenCalled_AndNoNewShipSunk_DoNothing()
        {
            int expected = 1;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            BattleshipsParts testParts = new BattleshipsParts(testShipsList);
            testParts.UpdateShipCount();

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"GamePartsTests_UpdateShipCount : Incorrect Ship Count value returned"));
        }

        [TestMethod]
        public void UpdateShipCount_WhenCalled_AndANewShipSunk_ModifiyShipCount()
        {
            int expected = 0;
            Ship testShip = new Ship(ShipTypes.Destroyer);
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            BattleshipsParts testParts = new BattleshipsParts(testShipsList);
            for (int i = 0; i < testShip.Length; i++)
            {
                testParts.Ships[0].Sections[i].Contents = 'x';
            }
            testParts.UpdateShipCount();

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"GamePartsTests_UpdateShipCount : Incorrect Ship Count value returned"));
        }
        [TestMethod]
        public void UpdateSunkFlag_WhenCalled_AndShipNotSunk_AndShipSectionsNotAllHit_DoNothing()
        {
            bool expected = false;
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);
            testShip.UpdateSunk();

            bool actual = testShip.Sunk;

            Assert.AreEqual(expected, actual, ($@"ShipTests_UpdateSunkFlag_NotSunk : Returned incorrect computed value."));
        }

        [TestMethod]
        public void UpdateSunkFlag_WhenCalled_AndShipNotSunk_AndShipSectionsAllHit_SetSunkFlag_True()
        {
            bool expected = true;
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);
            foreach (BoardSpace section in testShip.Sections)
            {
                section.Contents = 'x';
            }
            testShip.UpdateSunk();

            bool actual = testShip.Sunk;

            Assert.AreEqual(expected, actual, ($@"ShipTests_UpdateSunkFlag_Sunk : Returned computed set value."));
        }

        [TestMethod]
        public void UpdateSunkFlag_WhenCalled_AndShipSunk_DoNothing()
        {
            bool expected = true;
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);
            foreach (BoardSpace section in testShip.Sections)
            {
                section.Contents = 'x';
            }
            testShip.UpdateSunk(); // Sets up a sunk flag
            testShip.UpdateSunk(); // Method with already sunk ship

            bool actual = testShip.Sunk;

            Assert.AreEqual(expected, actual, ($@"ShipTests_UpdateSunkFlag_Sunk : Returned computed set value."));
        }

    }
}
