using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    public class FakeConsoleIO : ConsoleIO
    {
        private static int FakeUserInput = 0;
        public override void OutputText(string s)
        {           
        }
        public override string InputText()
        {
            if (FakeUserInput >= 26) {FakeUserInput = 0;}
            string[] ReturnList = { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5", "D1", "D2", "D3", "D4", "D5", "E1", "E2", "E3", "E4", "E5", "a" };
            string fakeUserInput = ReturnList[FakeUserInput];
            FakeUserInput++;
            return fakeUserInput;
        }
    }

    [TestClass]
    public class BattleshipsPlayTests
    {
        [TestMethod]
        public void BattleshipsPlayTests_GivenPlayWasCalled_WithValidArguments_GamePartsSet()
        {
            int testBoardSize = 5;
            ShipTypes[] testShipsList = { ShipTypes.Battleship };
            BattleshipsSetup testGameSetup = new BattleshipsSetup(testBoardSize, testShipsList);
            FakeConsoleIO testConsoleIO = new FakeConsoleIO();
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
            int testBoardSize = 5;
            ShipTypes[] testShipsList = { ShipTypes.Battleship };
            BattleshipsSetup testGameSetup = new BattleshipsSetup(testBoardSize, testShipsList);
            FakeConsoleIO testConsoleIO = new FakeConsoleIO();
            GameBoard testGameBoard = testGameSetup.GameBoard;
            GameParts testGameParts = testGameSetup.GameParts;
            BattleshipsPlay testBattleshipsPlay = new BattleshipsPlay(testGameBoard, testGameParts, testConsoleIO);
            var expected = testGameBoard;

            var actual = testBattleshipsPlay.GameBoard;

            Assert.AreEqual(expected, actual, "BattleshipsSetupTests_GameBoardSet : Game Board Not Set");
        }
    }
}