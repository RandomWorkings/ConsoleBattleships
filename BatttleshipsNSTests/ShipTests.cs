using BattleshipsNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ShipTests
    {
        [TestMethod]
        public void Ship_WhenShipCreated_WithValidShipType_SetType()
        {
            ShipTypes expected = ShipTypes.Battleship;
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);

            ShipTypes actual = testShip.Type;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_Type : Returned incorrect computed value"));
        }

        [TestMethod]
        public void Ship_WhenShipCreated_WithValidShipType_SetLength()
        {
            int expected = 4;
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);

            int actual = testShip.Length;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_Length : Returned incorrect computed value"));
        }
        
        [TestMethod]
        public void Ship_WhenShipCreated_WithValidShipType_SetSectionsLength()
        {
            int expected = 4;
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);

            int actual = testShip.Sections.Length;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_SectionLength : Returned incorrect computed value"));
        }
        
        [TestMethod]
        public void Orientation_WhenCalled_AndHasValidAssignment_SetOrientation()
        {
            int expected = 2;
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType)
            {
                Orientation = 2
            };

            int actual = testShip.Orientation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Orientation : Returned incorrect set value"));
        }
        
        [TestMethod]
        public void StartLocation_WhenCalled_AndHasValidAssignment_SetStartLocation()
        {
            (int, int) expected = (1, 1);
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType)
            {
                StartLocation = (1, 1)
            };

            (int, int) actual = testShip.StartLocation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_StartLocation : Returned incorrect set value"));
        }
        
        [TestMethod]
        public void UpdateSunkFlag_WhenCalled_AndShipSectionsNotAllHit_SetSunkFlag_False()
        {
            bool expected = false;
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);
            testShip.UpdateSunkFlag();

            bool actual = testShip.SunkFlag;

            Assert.AreEqual(expected, actual, ($@"ShipTests_UpdateSunkFlag_NotSunk : Returned incorrect computed value"));
        }
        
        [TestMethod]
        public void UpdateSunkFlag_WhenCalled_AndShipSectionsAllHit_SetSunkFlag_True()
        {
            bool expected = true;
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);
            foreach (BoardSpace section in testShip.Sections)
            {
                section.Contents = 'x';
            }
            testShip.UpdateSunkFlag();

            bool actual = testShip.SunkFlag;

            Assert.AreEqual(expected, actual, ($@"ShipTests_UpdateSunkFlag_Sunk : Returned computed set value"));
        }
    }
}