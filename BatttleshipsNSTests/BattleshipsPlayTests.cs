using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class BattleshipsPlayTests
    {
        [TestMethod]
        public void BattleshipsPlayTests_WhenGameplayStarts_ThenTheSystemChecksForUnsunkShips()
        {
            //Arrange, Given the application has started.

            //Act, When gameplay starts.

            //Assert, Then the system checks for unsunk ships.

        }

        [TestMethod]
        public void BattleshipsPlayTests_WhenThereAreUnsunkShips_ThenThePlayerIsAskedForAnInput()
        {
            //Arrange, Given the system has checked for unsunk ships.

            //Act, When there are unsunk ships.

            //Assert, Then the player is asked for an input.

        }

        [TestMethod]
        public void BattleshipsPlayTests_WhenThereAreNoSunkShips_ThenThePlayerIsTold_AndGameplayEnds()
        {
            //Arrange, Given the system has checked for unsunk ships.

            //Act, When there are no sunk ships.

            //Assert, Then the player is informed of winning the game.
            //	And gameplay ends.

        }

        [TestMethod]
        public void BattleshipsPlayTests_WhenUserInputsInvalidValue_ThenThePlayerIsInformedOfInvalidInput()
        {
            //Arrange, Given the user has been asked for an input.

            //Act, When the input entered is invalid.

            //Assert, Then the player is informed of entering an invalid input.

        }

        [TestMethod]
        public void BattleshipsPlayTests_WhenUserInputsValidValue_ThenInputHistoryIsRetrieved()
        {
            //Arrange, Given the user has been asked for an input.

            //Act, When the input entered is valid.

            //Assert, Then the system retrieves the input history.

        }

        [TestMethod]
        public void BattleshipsPlayTests_WhenAUserInputMatchesAnItemInHistory_ThenTheUserIsInformedOfDuplicate()
        {
            //Arrange, Given the system has retrieved the input history.

            //Act, When an input matches an item in the input history.

            //Assert, Then the player is informed of entering a duplicate input.

        }

        [TestMethod]
        public void BattleshipsPlayTests_WhenAUserInputMatchesAnItemInHistory_ThenHistoryIsUpdated_AndGridLocationIsChecked()
        {
            //Arrange, Given the system has retrieved the input history.

            //Act, When an input does not match anything in the input history.

            //Assert, Then the input history is updated.
            //	And the system checks the target grid location.

        }

        [TestMethod]
        public void BattleshipsPlayTests_WhenALocationIsUnoccupied_ThenThePlayerIsInformedOfMissing()
        {
            //Arrange, Given the system has checked the target grid location.

            //Act, When the location is not occupied.

            //Assert, Then the player is informed of missing a target.

        }

        [TestMethod]
        public void BattleshipsPlayTests_WhenALocationIsOccupied_ThenThePlayerIsInformedOfHitting_AndTheOccupyingShipSectionIsUpdated()
        {
            //Arrange, Given the system has checked the target grid location.

            //Act, When the location is occupied.

            //Assert, Then the player is informed of hitting a target.
            //	And the system updates the occupying ship's section.

        }

        [TestMethod]
        public void BattleshipsPlayTests_WhenAllShipSectionsAreHit_ThenTheShipIsSunk_AndThePlayerIsInformedOfSinking()
        {
            //Arrange, Given the system updated a ship's section.

            //Act, When all ship sections are hit.

            //Assert, Then the ship is sunk.
            //	And the player is informed of sinking a target.

        }
    }
}
