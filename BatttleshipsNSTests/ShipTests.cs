using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class ShipTests
    {
        [TestMethod]
        public void ShipTests_Type_WhenCalled_GivenNoArguments_ThenReturnsDefaultValue()
        {
            ShipTypes expected = ShipTypes.Battleship;
            IShip testShip = new Ship();

            ShipTypes actual = testShip.Type;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_Type : Returned incorrect computed value."));
        }
        [TestMethod]
        public void ShipTests_Type_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
        {
            ShipTypes expected = ShipTypes.Destroyer;
            ShipTypes testShipType = ShipTypes.Destroyer;
            IShip testShip = new Ship(testShipType);

            ShipTypes actual = testShip.Type;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_Type : Returned incorrect computed value."));
        }
        [TestMethod]
        public void ShipTests_Length_WhenCalled_GivenNoArguments_ThenReturnsDefaultValue()
        {
            int expected = (int)ShipTypes.Battleship;  //Enum associated value, the length of the ship
            IShip testShip = new Ship();

            int actual = testShip.Length;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_Length : Returned incorrect computed value."));
        }
        [TestMethod]
        public void ShipTests_Length_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
        {
            int expected = (int)ShipTypes.Destroyer;  //Enum associated value, the length of the ship
            ShipTypes testShipType = ShipTypes.Destroyer;
            IShip testShip = new Ship(testShipType);

            int actual = testShip.Length;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_Length : Returned incorrect computed value."));
        }
        [TestMethod]
        public void ShipTests_Sunk_WhenCalled_GivenNoArguments_ThenReturnsDefaultValue()
        {
            bool expected = false;
            Ship testShip = new Ship();

            bool actual = testShip.Sunk;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Sunk : Returned incorrect set value."));
        }
        [TestMethod]
        public void ShipTests_Sunk_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
        {
            bool expected = true;
            ShipTypes testShipType = ShipTypes.Destroyer;
            IShip testShip = new Ship(testShipType)
            {
                Sunk = true
            };

            bool actual = testShip.Sunk;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Sunk : Returned incorrect set value."));
        }
        [TestMethod]
        public void ShipTests_Placed_WhenCalled_GivenNoArguments_ThenReturnsDefaultValue()
        {
            bool expected = false;
            IShip testShip = new Ship();

            bool actual = testShip.Placed;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Placed : Returned incorrect set value."));
        }
        [TestMethod]
        public void ShipTests_Placed_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
        {
            bool expected = true;
            ShipTypes testShipType = ShipTypes.Destroyer;
            IShip testShip = new Ship(testShipType)
            {
                Placed = true
            };

            bool actual = testShip.Placed;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Placed : Returned incorrect set value."));
        }
        [TestMethod]
        public void ShipTests_Section_WhenCalled_GivenNoArguments_ThenSetDefaultArrayLength()
        {
            int expected = (int)ShipTypes.Battleship;  //Enum associated value, the length of the ship
            IShip testShip = new Ship();

            int actual = testShip.Sections.Length;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_SectionLength : Returned incorrect computed value."));
        }
        [TestMethod]
        public void ShipTests_Section_WhenCalled_GivenValidArguments_ThenSetCorrectArrayLength()
        {
            int expected = (int)ShipTypes.Destroyer;  //Enum associated value, the length of the ship
            ShipTypes testShipType = ShipTypes.Destroyer;
            IShip testShip = new Ship(testShipType);

            int actual = testShip.Sections.Length;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Ship_SectionLength : Returned incorrect computed value."));
        }
        [TestMethod]
        public void ShipTests_Orientation_WhenCalled_GivenNoArguments_ThenReturnsDefaultValue()
        {
            int expected = (int)ShipOrientations.Horizontal;
            IShip testShip = new Ship();

            int actual = testShip.Orientation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Orientation : Returned incorrect set value."));
        }
        [TestMethod]
        public void ShipTests_Orientation_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
        {
            int expected = (int)ShipOrientations.Vertical;
            ShipTypes testShipType = ShipTypes.Destroyer;
            IShip testShip = new Ship(testShipType)
            {
                Orientation = (int)ShipOrientations.Vertical
            };

            int actual = testShip.Orientation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_Orientation : Returned incorrect set value."));
        }
        [TestMethod]
        public void ShipTests_StartLocation_WhenCalled_GivenNoArguments_ThenReturnsDefaultValue()
        {
            (int, int) expected = (0, 0);
            IShip testShip = new Ship();

            (int, int) actual = testShip.StartLocation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_StartLocation : Returned incorrect set value."));
        }
        [TestMethod]
        public void ShipTests_StartLocation_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
        {
            (int, int) expected = (1, 1);
            ShipTypes testShipType = ShipTypes.Destroyer;
            IShip testShip = new Ship(testShipType)
            {
                StartLocation = (1, 1)
            };

            (int, int) actual = testShip.StartLocation;

            Assert.AreEqual(expected, actual, ($@"ShipTests_StartLocation : Returned incorrect set value."));
        }
    }
}