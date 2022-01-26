using BattleshipsNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ShipTests
    {
        //Shared Test Inputs
        private static readonly bool TestSunk = false;
        private static readonly int TestCount = 1;
        private static readonly int TestOrientation = 2;
        private static readonly (int, int) TestLocation = (10, 10);
        private static readonly ShipTypes TestType = ShipTypes.Battleship;
        private static readonly int TestLength = (int)TestType;

        [TestMethod]
        public void ID_WhenCalled_GetShipID()
        {
            Ship ship = new Ship(TestType, TestCount);
            string expected = TestType + " - s" + TestCount;

            string actual = ship.ID;

            Assert.AreEqual(expected, actual, ($@"ShipTests_ID : Returned incorrect Ship ID value"));
        }
        [TestMethod]
        public void Type_WhenCalled_GetShipType()
        {
            Ship ship = new Ship(TestType, TestCount);
            ShipTypes expected = TestType;

            ShipTypes actual = ship.Type;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Length : Returned incorrect Ship Length value"));
        }
        [TestMethod]
        public void Length_WhenCalled_GetShipLength()
        {
            Ship ship = new Ship(TestType, TestCount);
            int expected = TestLength;

            int actual = ship.Length;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Length : Returned incorrect Ship Length value"));
        }
        [TestMethod]
        public void SunkFlag_WhenCalled_GetShipSunkFlag()
        {
            Ship ship = new Ship(TestType, TestCount);
            bool expected = TestSunk;

            bool actual = ship.SunkFlag;

            Assert.AreEqual(expected, actual, ($@"ShipTests_SunkFlag : Returned incorrect Sunk Flag value"));
        }
        [TestMethod]
        public void Orientation_WhenCalled_WithValidAssignment_SetShipOrientation()
        {
            Ship ship = new Ship(TestType, TestCount);
            int expected = TestOrientation;

            ship.Orientation = TestOrientation;
            int actual = ship.Orientation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Orientation : Returned incorrect Oreientation value"));
        }
        [TestMethod]
        public void StartLocation_WhenCalled_WithValidAssignment_SetShipStartLocation()
        {
            Ship ship = new Ship(TestType, TestCount);
            (int, int) expected = TestLocation;

            ship.StartLocation = TestLocation;
            (int, int) actual = ship.StartLocation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Orientation : Returned incorrect Start Location value"));
        }
        [TestMethod]
        public void Sections_WhenCalled_GetSections()
        {
            int expectedSectionCount = TestLength;
            Ship ship = new Ship(TestType, TestCount);

            int actualSectionCount = ship.Sections.GetLength(0);

            Assert.AreEqual(expectedSectionCount, actualSectionCount, ($@"GridTests_PlayGrid : Returned incorrect Array index count"));
            for (int i = 0; i < TestLength; i++)
            {
                Assert.AreEqual((ship.Sections[i]), null, ($@"GridTests_PlayGrid: Returned incorrect Array Contents Type"));
            }
        }


        [TestMethod]
        public void Ship_WhenCalled_WithValidParameters_InitializeDefaultShipValues()
        {
            //Arrange
            Ship ship = new Ship(TestType, TestCount);
            bool expectedSunkFlag = false;
            int expectedOrientation = 1;
            (int, int) expectedLocation = (0, 0);

            //Act
            bool actualSunkFlag = ship.SunkFlag;
            int actualOrientation = ship.Orientation;
            (int, int) actualLocation = ship.StartLocation;
            GridCell[] actualSections = ship.Sections;

            //Assess
            Assert.AreEqual(expectedSunkFlag, actualSunkFlag, ($@"ShipTests_Ship : Returned incorrect Default Sunk Flag value."));
            Assert.AreEqual(expectedOrientation, actualOrientation, ($@"ShipTests_Ship : Returned incorrect Default Orientation value."));
            Assert.AreEqual(expectedLocation, actualLocation, ($@"ShipTests_Ship : Returned incorrect Default Start Location value."));
            Assert.IsInstanceOfType(actualSections, typeof(GridCell[]), ($@"ShipTests_Ship : Returned incorrect Default Section Array Type."));
            for (int i = 0; i < ship.Length; i++)
            {
                Assert.AreEqual((actualSections[i]), null, ($@"GridTests_PlayGrid: Returned incorrect Default Array Contents Type"));
            }
        }


        /*Code To Test Not Implemented*/
        [TestMethod]
        public void PlaceShip_WhenCalled_WithValidParameters_DO()
        {
            //Arrange

            //Act

            //Assess
            //Assert.AreEqual(expected, actual, ($@"ShipTests_METHOD : ERROR"));
        }
        [TestMethod]
        public void UpdateSunkFlag_WhenCalled_DO()
        {
            //Arrange

            //Act

            //Assess
            //Assert.AreEqual(expected, actual, ($@"ShipTests_METHOD : ERROR"));
        }


    }
}