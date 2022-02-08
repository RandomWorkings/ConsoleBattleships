using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class BattleshipsSetupTests
    {
        [TestMethod]
        public void BattleshipsSetupTests_WhenSetupStarting_AGridIsCreated()
        {
            //Arrange, Given the application has started.

            //Act, When setup starts.

            //Assert, Then a play grid is created.

        }

        [TestMethod]
        public void BattleshipsSetupTests_WhenThereAreNoUnplacedShips_SetupEnds()
        {
            //Arrange, Given a play grid exists.

            //Act, When there are no unplaced ships.

            //Assert, Then setup ends.

        }

        [TestMethod]
        public void BattleshipsSetupTests_WhenThereAreUnplacedShips_ThatAnUnplacedShipIsSelected()
        {
            //Arrange, Given a play grid exists.

            //Act, When there are unplaced ships.

            //Assert, the system will select an unplaced ship.

        }

        [TestMethod]
        public void BattleshipsSetupTests_WhenShipHasPositionNotOverlappingOtherShip_AndNotOverhangingPlayGrid_ThatShipisPlaced()
        {
            //Arrange, Given a ship is selected.

            //Act, When the ship is assigned a position that does not overlap another ship.
            //	And the ship does not overhang the play grid.

            //Assert, Then the ship is placed.

        }

        [TestMethod]
        public void BattleshipsSetupTests_WhenShipHasPositionOverlappingOtherShip_AndNotOverhangingPlayGrid_ThatShipisGivenNewPosition()
        {
            //Arrange, Given a ship is selected.

            //Act, When the ship is assigned a position that overlaps another ship.
            //	And the ship does not overhang the play grid.

            //Assert, Then the ship is assigned a new position.

        }

        [TestMethod]
        public void BattleshipsSetupTests_WhenShipHasPositionNotOverlappingOtherShip_AndOverhangingPlayGrid_ThatShipisGivenNewPosition()
        {
            //Arrange, Given a ship is selected.

            //Act, When the ship is assigned a position that does not overlap another ship.
            //	And the ship overhangs the play grid. 

            //Assert, Then the ship is assigned a new position.

        }

    }
}