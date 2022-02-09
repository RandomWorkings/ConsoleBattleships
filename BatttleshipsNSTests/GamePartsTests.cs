using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class GamePartsTests
    {
        [TestMethod]
        public void GameParts_WhenCalled_WithValidArguments_SetShipCount()
        {
            int expected = 1;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            BattleshipsShips testParts = new BattleshipsShips(testShipsList);

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"GamePartsTests_SetShipCount : Incorrect Ship Count value returned"));
        }

        [TestMethod]
        public void GameParts_WhenCalled_WithValidArguments_SetShipArrayLength()
        {
            int expected = 1;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            BattleshipsShips testParts = new BattleshipsShips(testShipsList);

            int actual = testParts.Ships.Length;

            Assert.AreEqual(expected, actual, ($@"GamePartsTests_SetShipArrayLength : Incorrect Ship Array Length value returned"));
        }

        [TestMethod]
        public void GameParts_WhenCalled_WithValidArguments_SetArrayContents()
        {
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            BattleshipsShips testParts = new BattleshipsShips(testShipsList);

            BattleshipsShip actual = testParts.Ships[0];

            Assert.IsNotNull(actual, $@"GamePartsTests_SetArrayContent : No Array Contents exists");
        }

        [TestMethod]
        public void UpdateShipCount_WhenCalled_AndNoNewShipSunk_DoNothing()
        {
            int expected = 1;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            BattleshipsShips testParts = new BattleshipsShips(testShipsList);
            testParts.UpdateShipCount();

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"GamePartsTests_UpdateShipCount : Incorrect Ship Count value returned"));
        }

        [TestMethod]
        public void UpdateShipCount_WhenCalled_AndANewShipSunk_ModifiyShipCount()
        {
            int expected = 0;
            BattleshipsShip testShip = new BattleshipsShip(ShipTypes.Destroyer);
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            BattleshipsShips testParts = new BattleshipsShips(testShipsList);
            for (int i = 0; i < testShip.Length; i++)
            {
                testParts.Ships[0].Sections[i].Contents = 'x';
            }
            testParts.UpdateShipCount();

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"GamePartsTests_UpdateShipCount : Incorrect Ship Count value returned"));
        }
    }
}
