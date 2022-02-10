using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class BattleshipsPartsTests
    {
        [TestMethod]
        public void BattleshipsParts_WhenCalled_GivenNoArguments_ThenSetDefaultShipCount()
        {
            int expected = 3;
            BattleshipsParts testParts = new BattleshipsParts();

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"BattleshipsPartsTests_SetShipCount : Incorrect Ship Count value returned"));
        }

        [TestMethod]
        public void BattleshipsParts_WhenCalled_GivenValidArguments_ThenSetCorrectShipCount()
        {
            int expected = 1;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            IBattleshipsParts testParts = new BattleshipsParts(testShipsList);

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"BattleshipsPartsTests_SetShipCount : Incorrect Ship Count value returned"));
        }
        [TestMethod]
        public void BattleshipsParts_WhenCalled_GivenValidArguments_ThenSetDefaultShipArrayLength()
        {
            int expected = 3;
            IBattleshipsParts testParts = new BattleshipsParts();

            int actual = testParts.Ships.Length;

            Assert.AreEqual(expected, actual, ($@"BattleshipsPartsTests_SetShipArrayLength : Incorrect Ship Array Length value returned"));
        }
        [TestMethod]
        public void BattleshipsParts_WhenCalled_GivenValidArguments_ThenSetCorrectShipArrayLength()
        {
            int expected = 1;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            IBattleshipsParts testParts = new BattleshipsParts(testShipsList);

            int actual = testParts.Ships.Length;

            Assert.AreEqual(expected, actual, ($@"BattleshipsPartsTests_SetShipArrayLength : Incorrect Ship Array Length value returned"));
        }
        [TestMethod]
        public void BattleshipsParts_WhenCalled_GivenNo_ThenSetDefaultArrayContents()
        {
           IBattleshipsParts testParts = new BattleshipsParts();

            IShip actual = testParts.Ships[0];

            Assert.IsNotNull(actual, $@"BattleshipsPartsTests_SetArrayContent : No Array Contents exists");
        }
        [TestMethod]
        public void BattleshipsParts_WhenCalled_GivenValidArguments_ThenSetCorrectArrayContents()
        {
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            IBattleshipsParts testParts = new BattleshipsParts(testShipsList);

            IShip actual = testParts.Ships[0];

            Assert.IsNotNull(actual, $@"BattleshipsPartsTests_SetArrayContent : No Array Contents exists");
        }
        [TestMethod]
        public void BattleshipsParts_UpdateShipCount_WhenCalled_GivenNoShipSunk_ThenReturnCorrectValue()
        {
            int expected = 1;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            IBattleshipsParts testParts = new BattleshipsParts(testShipsList);
            testParts.UpdateShipCount();

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"BattleshipsPartsTests_UpdateShipCount : Incorrect Ship Count value returned"));
        }
        [TestMethod]
        public void BattleshipsParts_UpdateShipCount_WhenCalled_GivenAShipSunk_ThenReturnCorrectValue()
        {
            int expected = 0;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            IBattleshipsParts testParts = new BattleshipsParts(testShipsList);
            for (int i = 0; i < testParts.Ships[0].Length; i++)
            {
                testParts.Ships[0].Sections[i].Contents = 'x';
            }
            testParts.UpdateShipCount();

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"BattleshipsPartsTests_UpdateShipCount : Incorrect Ship Count value returned"));
        }
    }
}
