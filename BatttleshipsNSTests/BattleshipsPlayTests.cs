using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    public class FakeConsoleIO : ITextIO
    {
        private string[] ReturnList = {"A1","A2","A3","A4", "A1", "B1", "C1", "D1"};
        private static int FakeUserInput = 0;
        public void WriteLine(string s)
        {           
        }
        public string ReadLine()
        {
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
            int testBoardSize = 4;
            ShipTypes[] testShipsList = { ShipTypes.Battleship };
            BattleshipsSetup testSetup = new BattleshipsSetup(testBoardSize, testShipsList);

            FakeConsoleIO testConsoleIO = new FakeConsoleIO();
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
            FakeConsoleIO testConsoleIO = new FakeConsoleIO();
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