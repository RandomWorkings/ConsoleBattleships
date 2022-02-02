using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class GamePartsTests
    {
        [TestMethod]
        public void GameParts_WhenCalled_WithValidArguments_SetShipCount()
        {
            int expected = 1;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            GameParts testParts = new GameParts(testShipsList);

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"GameParts_SetShipCount : Incorrect Ship Count value returned"));
        }
        
        [TestMethod]
        public void GameParts_WhenCalled_WithValidArguments_SetShipArrayLength()
        {
            int expected = 1;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            GameParts testParts = new GameParts(testShipsList);

            int actual = testParts.Ships.Length;

            Assert.AreEqual(expected, actual, ($@"GameParts_SetShipArrayLength : Incorrect Ship Array Length value returned"));
        }
        
        [TestMethod]
        public void GameParts_WhenCalled_WithValidArguments_SetArrayContents()
        {
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            GameParts testParts = new GameParts(testShipsList);

            Ship actual = testParts.Ships[0];

            Assert.IsNotNull(actual, $@"GameParts_SetArrayContent : No Array Contents exists");
        }
        
        [TestMethod]
        public void UpdateShipCount_WhenCalled_AndNoNewShipSunk_DoNothing()
        {
            int expected = 1;
            Ship testShip = new Ship(ShipTypes.Destroyer);
            ShipTypes[] testShipsList = { ShipTypes.Destroyer };
            GameParts testParts = new GameParts(testShipsList);
            testParts.UpdateShipCount();

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"GameParts_UpdateShipCount : Incorrect Ship Count value returned"));
        }

        [TestMethod]
        public void UpdateShipCount_WhenCalled_AndANewShipSunk_ModifiyShipCount()
        {
            int expected = 0;
            Ship testShip = new Ship(ShipTypes.Destroyer);
            ShipTypes[] testShipsList = { ShipTypes.Destroyer};
            GameParts testParts = new GameParts(testShipsList);
            for(int i = 0; i < testShip.Length, i++)
            { 
                testParts.Ships[0].Sections[i].Contents = 'x';
            }
            testParts.UpdateShipCount();

            int actual = testParts.ShipCount;

            Assert.AreEqual(expected, actual, ($@"GameParts_UpdateShipCount : Incorrect Ship Count value returned"));
        }

    }
}
