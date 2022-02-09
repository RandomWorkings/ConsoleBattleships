using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class BattleshipsPlayTests
    {
        [TestMethod]
        public void BattleshipsPlayTests_GivenPlayWasCalled_WithValidArguments_GamePartsSet()
        {
            ConsoleIO testConsoleIO = new ConsoleIO();
            BattleshipsSetup testGameSetup = new BattleshipsSetup();
            GameBoard testGameBoard = testGameSetup.GameBoard;
            GameParts testGameParts = testGameSetup.GameParts;
            BattleshipsPlay testBattleshipsPlay = new BattleshipsPlay(testGameBoard,testGameParts,testConsoleIO);
            var expected = testGameParts;

            var actual = testBattleshipsPlay.GameParts;

            Assert.AreEqual(expected, actual, "BattleshipsSetupTests_GamePartsSet : Game Board Not Set");
        }
        [TestMethod]
        public void BattleshipsPlayTests_GivenPlayWasCalled_WithValidArguments_GameBoardSet()
        {
            ConsoleIO testConsoleIO = new ConsoleIO();
            BattleshipsSetup testGameSetup = new BattleshipsSetup();
            GameBoard testGameBoard = testGameSetup.GameBoard;
            GameParts testGameParts = testGameSetup.GameParts;
            BattleshipsPlay testBattleshipsSetup = new BattleshipsPlay(testGameBoard, testGameParts, testConsoleIO);
            var expected = testGameBoard;

            var actual = testBattleshipsSetup.GameBoard;

            Assert.AreEqual(expected, actual, "BattleshipsSetupTests_GameBoardSet : Game Board Not Set");
        }
    }
}