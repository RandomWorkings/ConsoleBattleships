using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class ShipTests
    {
        [TestMethod]
        public void Ship_WhenCalled_WithValidArguments_SetType()
        {
            ShipTypes expected = ShipTypes.Battleship;
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);

            ShipTypes actual = testShip.Type;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_Type : Returned incorrect computed value."));
        }

        [TestMethod]
        public void Ship_WhenCalled_WithValidArguments_SetLength()
        {
            int expected = (int)ShipTypes.Battleship;  //Enum associated value, the length of the ship
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);

            int actual = testShip.Length;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_Length : Returned incorrect computed value."));
        }

        [TestMethod]
        public void Ship_WhenCalled_WithValidArguments_SetSectionsLength()
        {
            int expected = (int)ShipTypes.Battleship;  //Enum associated value, the length of the ship
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);

            int actual = testShip.Sections.Length;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_SectionLength : Returned incorrect computed value."));
        }

        [TestMethod]
        public void Orientation_WhenCalled_WithValidAssignment_SetOrientation()
        {
            int expected = 2;
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType)
            {
                Orientation = 2
            };

            int actual = testShip.Orientation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Orientation : Returned incorrect set value."));
        }

        [TestMethod]
        public void StartLocation_WhenCalled_WithValidAssignment_SetStartLocation()
        {
            (int, int) expected = (1, 1);
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType)
            {
                StartLocation = (1, 1)
            };

            (int, int) actual = testShip.StartLocation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_StartLocation : Returned incorrect set value."));
        }

        public void PlaceShip_WhenCalled_WithValidArguments_SetPlaced()
        {
            bool expected = true;
            int testSize = (int)ShipTypes.Battleship; //Enum associated value, the length of the ship
            ShipTypes testShipType = ShipTypes.Battleship;
            Ship testShip = new Ship(testShipType);
            GameBoard testBoard = new GameBoard(testSize);
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
            GameBoard testBoard = new GameBoard(testSize);

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
            GameBoard testBoard = new GameBoard(testSize);

            testShip.PlaceShip(testBoard);
            bool actual = testShip.Sections[0].Occupied;

            Assert.AreEqual(expected, actual, ($@"ShipTests_PlaceShip : Incorrect section assignment."));
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