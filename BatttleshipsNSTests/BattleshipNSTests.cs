using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class BattleshipNSTests
    {
        [TestMethod]
        public void Test_WhenSetupStarting_AGridIsCreated()
        {
            //Arrange, Given the application has started.

            //Act, When setup starts.

            //Assert, Then a play grid is created.

        }

        [TestMethod]
        public void Test_WhenThereAreNoUnplacedShips_SetupEnds()
        {
            //Arrange, Given a play grid exists.

            //Act, When there are no unplaced ships.

            //Assert, Then setup ends.

        }

        [TestMethod]
        public void Test_WhenThereAreUnplacedShips_ThatAnUnplacedShipIsSelected()
        {
            //Arrange, Given a play grid exists.

            //Act, When there are unplaced ships.

            //Assert, the system will select an unplaced ship.

        }

        [TestMethod]
        public void Test_WhenShipHasPositionNotOverlappingOtherShip_AndNotOverhangingPlayGrid_ThatShipisPlaced()
        {
            //Arrange, Given a ship is selected.

            //Act, When the ship is assigned a position that does not overlap another ship.
            //	And the ship does not overhang the play grid.

            //Assert, Then the ship is placed.

        }

        [TestMethod]
        public void Test_WhenShipHasPositionOverlappingOtherShip_AndNotOverhangingPlayGrid_ThatShipisGivenNewPosition()
        {
            //Arrange, Given a ship is selected.

            //Act, When the ship is assigned a position that overlaps another ship.
            //	And the ship does not overhang the play grid.

            //Assert, Then the ship is assigned a new position.

        }


        [TestMethod]
        public void Test_WhenShipHasPositionNotOverlappingOtherShip_AndOverhangingPlayGrid_ThatShipisGivenNewPosition()
        {
            //Arrange, Given a ship is selected.

            //Act, When the ship is assigned a position that does not overlap another ship.
            //	And the ship overhangs the play grid. 

            //Assert, Then the ship is assigned a new position.

        }
        [TestMethod]
        public void Test_WhenGameplayStarts_ThenTheSystemChecksForUnsunkShips()
        {
            //Arrange, Given the application has started.

            //Act, When gameplay starts.

            //Assert, Then the system checks for unsunk ships.

        }

        [TestMethod]
        public void Test_WhenThereAreUnsunkShips_ThenThePlayerIsAskedForAnInput()
        {
            //Arrange, Given the system has checked for unsunk ships.

            //Act, When there are unsunk ships.

            //Assert, Then the player is asked for an input.

        }

        [TestMethod]
        public void Test_WhenThereAreNoSunkShips_ThenThePlayerIsTold_AndGameplayEnds()
        {
            //Arrange, Given the system has checked for unsunk ships.

            //Act, When there are no sunk ships.

            //Assert, Then the player is informed of winning the game.
            //	And gameplay ends.

        }

        [TestMethod]
        public void Test_WhenUserInputsInvalidValue_ThenThePlayerIsInformedOfInvalidInput()
        {
            //Arrange, Given the user has been asked for an input.

            //Act, When the input entered is invalid.

            //Assert, Then the player is informed of entering an invalid input.

        }

        [TestMethod]
        public void Test_WhenUserInputsValidValue_ThenInputHistoryIsRetrieved()
        {
            //Arrange, Given the user has been asked for an input.

            //Act, When the input entered is valid.

            //Assert, Then the system retrieves the input history.

        }

        [TestMethod]
        public void Test_WhenAUserInputMatchesAnItemInHistory_ThenTheUserIsInformedOfDuplicate()
        {
            //Arrange, Given the system has retrieved the input history.

            //Act, When an input matches an item in the input history.

            //Assert, Then the player is informed of entering a duplicate input.

        }

        [TestMethod]
        public void Test_WhenAUserInputMatchesAnItemInHistory_ThenHistoryIsUpdated_AndGridLocationIsChecked()
        {
            //Arrange, Given the system has retrieved the input history.

            //Act, When an input does not match anything in the input history.

            //Assert, Then the input history is updated.
            //	And the system checks the target grid location.

        }

        [TestMethod]
        public void Test_WhenALocationIsUnoccupied_ThenThePlayerIsInformedOfMissing()
        {
            //Arrange, Given the system has checked the target grid location.

            //Act, When the location is not occupied.

            //Assert, Then the player is informed of missing a target.

        }

        [TestMethod]
        public void Test_WhenALocationIsOccupied_ThenThePlayerIsInformedOfHitting_AndTheOccupyingShipSectionIsUpdated()
        {
            //Arrange, Given the system has checked the target grid location.

            //Act, When the location is occupied.

            //Assert, Then the player is informed of hitting a target.
            //	And the system updates the occupying ship's section.

        }

        [TestMethod]
        public void Test_WhenAllShipSectionsAreHit_ThenTheShipIsSunk_AndThePlayerIsInformedOfSinking()
        {
            //Arrange, Given the system updated a ship's section.

            //Act, When all ship sections are hit.

            //Assert, Then the ship is sunk.
            //	And the player is informed of sinking a target.

        }


    }
}
