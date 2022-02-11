using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    public class FakeUserIO : ConsoleIO
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
    public class BattleshipsGameTests
    {
    
        [TestMethod]
        public void BattleshipsGameTests_Board_GivenBattleshipsGameCalled_WhenSuppliedValidArguments_ThenSetBoard()
        {
            IBattleshipsBoard testBoard = new BattleshipsBoard();
            IBattleshipsParts testParts = new BattleshipsParts();
            ITextIO testTextIO = new FakeUserIO();
            IInputHandler testInputHandler = new InputHandler(testBoard.BoardSize);
            IOutputGenerator testOutputGenerator = new OutputGenerator();
            IValueGenerator testValueGenerator = new ValueGenerator();
            IBattleshipsSetup testGameSetup = new BattleshipsSetup(testBoard, testParts, testValueGenerator);
            testGameSetup.RunSetup();
            IBattleshipsGame testGame = new BattleshipsGame(testGameSetup, testTextIO, testInputHandler, testOutputGenerator);

            var expected = testBoard;

            var actual = testGame.Board;

            Assert.AreEqual(expected, actual, "BattleshipsGameTests_Board : Incorrect value returned");
        }
        [TestMethod]
        public void BattleshipsGameTests_Parts_GivenBattleshipsGameCalled_WhenSuppliedValidArguments_ThenSetParts()
        {
            IBattleshipsBoard testBoard = new BattleshipsBoard();
            IBattleshipsParts testParts = new BattleshipsParts();
            ITextIO testTextIO = new FakeUserIO();
            IInputHandler testInputHandler = new InputHandler(testBoard.BoardSize);
            IOutputGenerator testOutputGenerator = new OutputGenerator();
            IValueGenerator testValueGenerator = new ValueGenerator();
            IBattleshipsSetup testGameSetup = new BattleshipsSetup(testBoard, testParts, testValueGenerator);
            testGameSetup.RunSetup();
            IBattleshipsGame testGame = new BattleshipsGame(testGameSetup, testTextIO, testInputHandler, testOutputGenerator);

            var expected = testParts;

            var actual = testGame.Parts;

            Assert.AreEqual(expected, actual, "BattleshipsGameTests_Parts : Incorrect value returned");
        }
        [TestMethod]
        public void BattleshipsGameTests_UI_GivenBattleshipsGameCalled_WhenSuppliedValidArguments_ThenSetOutputGenerator()
        {
            IBattleshipsBoard testBoard = new BattleshipsBoard();
            IBattleshipsParts testParts = new BattleshipsParts();
            ITextIO testTextIO = new FakeUserIO();
            IInputHandler testInputHandler = new InputHandler(testBoard.BoardSize);
            IOutputGenerator testOutputGenerator = new OutputGenerator();
            IValueGenerator testValueGenerator = new ValueGenerator();
            IBattleshipsSetup testGameSetup = new BattleshipsSetup(testBoard, testParts, testValueGenerator);
            testGameSetup.RunSetup();
            IBattleshipsGame testGame = new BattleshipsGame(testGameSetup, testTextIO, testInputHandler, testOutputGenerator);

            var expected = testOutputGenerator;

            var actual = testGame.UI;

            Assert.AreEqual(expected, actual, "BattleshipsGameTests_UI : Incorrect value returned");
        }
        [TestMethod]
        public void BattleshipsGameTests_InputHandler_GivenBattleshipsGameCalled_WhenSuppliedValidArguments_ThenSetInputHandler()
        {
            IBattleshipsBoard testBoard = new BattleshipsBoard();
            IBattleshipsParts testParts = new BattleshipsParts();
            ITextIO testTextIO = new FakeUserIO();
            IInputHandler testInputHandler = new InputHandler(testBoard.BoardSize);
            IOutputGenerator testOutputGenerator = new OutputGenerator();
            IValueGenerator testValueGenerator = new ValueGenerator();
            IBattleshipsSetup testGameSetup = new BattleshipsSetup(testBoard, testParts, testValueGenerator);
            testGameSetup.RunSetup();
            IBattleshipsGame testGame = new BattleshipsGame(testGameSetup, testTextIO, testInputHandler, testOutputGenerator);

            var expected = testInputHandler;

            var actual = testGame.InputHandler ;

            Assert.AreEqual(expected, actual, "BattleshipsGameTests_InputHandler : Incorrect Value returned");
        }
        [TestMethod]
        public void BattleshipsGameTests_TextIO_GivenBattleshipsGameCalled_WhenSuppliedValidArguments_ThenSetTextIO()
        {
            IBattleshipsBoard testBoard = new BattleshipsBoard();
            IBattleshipsParts testParts = new BattleshipsParts();
            ITextIO testTextIO = new FakeUserIO();
            IInputHandler testInputHandler = new InputHandler(testBoard.BoardSize);
            IOutputGenerator testOutputGenerator = new OutputGenerator();
            IValueGenerator testValueGenerator = new ValueGenerator();
            IBattleshipsSetup testGameSetup = new BattleshipsSetup(testBoard, testParts, testValueGenerator);
            testGameSetup.RunSetup();
            IBattleshipsGame testGame = new BattleshipsGame(testGameSetup, testTextIO, testInputHandler, testOutputGenerator);

            var expected = testTextIO;

            var actual = testGame.TextIO;

            Assert.AreEqual(expected, actual, "BattleshipsGameTests_TextIO : Incorrect Value returned");
        }
        [TestMethod]
        public void BattleshipsGameTests_RunGame_GivenCalled_WhenUserWinsGame_ThenCorrectFinalMessageIsDisplayed()
        {
            ITextIO testerIO = new ConsoleIO();
            int testBoardSize = 4;
            ShipTypes[] testShipsList = { ShipTypes.Destroyer};
            IBattleshipsBoard testBoard = new BattleshipsBoard(testBoardSize);
            IBattleshipsParts testParts = new BattleshipsParts(testShipsList);
            ITextIO testTextIO = new FakeUserIO();
            IInputHandler testInputHandler = new InputHandler(testBoard.BoardSize);
            IOutputGenerator testOutputGenerator = new OutputGenerator();
            IValueGenerator testValueGenerator = new ValueGenerator();
            IBattleshipsSetup testGameSetup = new BattleshipsSetup(testBoard, testParts, testValueGenerator);
            testGameSetup.RunSetup();
            IBattleshipsGame testGame = new BattleshipsGame(testGameSetup, testTextIO, testInputHandler, testOutputGenerator);
            testGame.RunGame();

            var expectedAlmost = "\tYou won the game.\n\tCongratulations\n";
            var expected = expectedAlmost.Replace("\n", "\r\n");

            var actual = testerIO.InputText();

            Assert.AreEqual(expected, actual, "BattleshipsGameTests_RunGame : Final message not displayed.");
        }
    }
}