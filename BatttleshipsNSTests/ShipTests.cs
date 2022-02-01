using BattleshipsNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ShipTests
    {
        [TestMethod]
        public void Ship_WhenShipCreated_WithShipTypeAndInt_SetsID()
        {
            string expected = "Battleship - s0";
            ShipTypes testShipType = ShipTypes.Battleship;
            int testShipNumber = 0;
            Ship testShip = new Ship(testShipType, testShipNumber);

            string actual = testShip.ID;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_ID : Returned incorrect computed ID value"));
        }
        [TestMethod]
        public void Ship_WhenShipCreated_WithShipTypeAndInt_SetsType()
        {
            ShipTypes expected = ShipTypes.Battleship;
            ShipTypes testShipType = ShipTypes.Battleship;
            int testShipNumber = 0;
            Ship testShip = new Ship(testShipType, testShipNumber);

            ShipTypes actual = testShip.Type;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_Type : Returned incorrect computed value"));
        }
        [TestMethod]
        public void Ship_WhenShipCreated_WithShipTypeAndInt_SetsLength()
        {
            int expected = 4;
            ShipTypes testShipType = ShipTypes.Battleship;
            int testShipNumber = 0;
            Ship testShip = new Ship(testShipType, testShipNumber);

            int actual = testShip.Length;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_Length : Returned incorrect computed value"));
        }
        [TestMethod]
        public void Ship_WhenShipCreated_WithShipTypeAndInt_SetsSunkFlag()
        {
            bool expected = false;
            ShipTypes testShipType = ShipTypes.Battleship;
            int testShipNumber = 0;
            Ship testShip = new Ship(testShipType, testShipNumber);

            bool actual = testShip.SunkFlag;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_SunkFlag : Returned incorrect set value"));
        }
        [TestMethod]
        public void Ship_WhenShipCreated_WithShipTypeAndInt_SetsOrientation()
        {
            int expected = 1;
            ShipTypes testShipType = ShipTypes.Battleship;
            int testShipNumber = 0;
            Ship testShip = new Ship(testShipType, testShipNumber);

            int actual = testShip.Orientation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_Orientation : Returned incorrect set value"));
        }
        [TestMethod]
        public void Ship_WhenShipCreated_WithShipTypeAndInt_SetsStartLocation()
        {
            (int, int) expected = (0, 0);
            ShipTypes testShipType = ShipTypes.Battleship;
            int testShipNumber = 0;
            Ship testShip = new Ship(testShipType, testShipNumber);

            (int, int) actual = testShip.StartLocation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_StartLocation : Returned incorrect set value"));
        }
        [TestMethod]
        public void Ship_WhenShipCreated_WithShipTypeAndInt_SetsSectionsLength()
        {
            int expected = 4;
            ShipTypes testShipType = ShipTypes.Battleship;
            int testShipNumber = 0;
            Ship testShip = new Ship(testShipType, testShipNumber);

            int actual = testShip.Sections.Length;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_SectionLength : Returned incorrect computed value"));
        }
        [TestMethod]
        public void Orientation_WhenCalled_AndAssignedValidAssignment_SetShipOrientation()
        {
            int expected = 2;
            ShipTypes testShipType = ShipTypes.Battleship;
            int testShipNumber = 0;
            Ship testShip = new Ship(testShipType, testShipNumber)
            {
                Orientation = 2
            };

            int actual = testShip.Orientation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Orientation : Returned incorrect set value"));
        }
        [TestMethod]
        public void StartLocation_WhenCalled_AndAssignedValidAssignment_SetShipStartLocation()
        {
            (int, int) expected = (1, 1);
            ShipTypes testShipType = ShipTypes.Battleship;
            int testShipNumber = 0;
            Ship testShip = new Ship(testShipType, testShipNumber)
            {
                StartLocation = (1, 1)
            };

            (int, int) actual = testShip.StartLocation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_StartLocation : Returned incorrect set value"));
        }
        public void UpdateSunkFlag_WhenCalled_AndShipSectionsNotAllHit_SetSunkFlag_False()
        {
            bool expected = false;
            ShipTypes testShipType = ShipTypes.Battleship;
            int testShipNumber = 0;
            Ship testShip = new Ship(testShipType, testShipNumber);
            testShip.UpdateSunkFlag();

            bool actual = testShip.SunkFlag;

            Assert.AreEqual(expected, actual, ($@"ShipTests_UpdateSunkFlag_NotSunk : Returned incorrect computed value"));
        }
        public void UpdateSunkFlag_WhenCalled_AndShipSectionsAllHit_SetSunkFlag_True()
        {
            bool expected = true;
            ShipTypes testShipType = ShipTypes.Battleship;
            int testShipNumber = 0;
            Ship testShip = new Ship(testShipType, testShipNumber);
            foreach (BoardSpace section in testShip.Sections)
            {
                section.Contents = 'o';
            }

            bool actual = testShip.SunkFlag;

            Assert.AreEqual(expected, actual, ($@"ShipTests_UpdateSunkFlag_Sunk : Returned computed set value"));
        }
    }
}