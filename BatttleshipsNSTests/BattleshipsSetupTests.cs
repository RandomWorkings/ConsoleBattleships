using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;
using System.Linq;

namespace BattleshipsNSTests
{
    [TestClass]
    public class BattleshipsSetupTests
    {
        [TestMethod]
        public void BattleshipsSetup_WhenCalled_GivenValidArguments_ThenSetsGameBoardValue()
       {
            IBattleshipsBoard testBoard = new BattleshipsBoard();
            IBattleshipsParts testParts = new BattleshipsParts();
            IValueGenerator testValueGenerator = new ValueGenerator();
            IBattleshipsSetup testSetup = new BattleshipsSetup(testBoard, testParts, testValueGenerator);
            IBattleshipsBoard expected = testBoard;

            IBattleshipsBoard actual = testSetup.GameBoard;

            Assert.AreEqual(expected, actual, "BattleshipsSetup_BattleshipsSetup_GameBoard : Incorrect value returned");
        }
        [TestMethod]
        public void BattleshipsSetup_WhenCalled_GivenValidArguments_ThenSetsGamePartsValue()
        {
            IBattleshipsBoard testBoard = new BattleshipsBoard();
            IBattleshipsParts testParts = new BattleshipsParts();
            IValueGenerator testValueGenerator = new ValueGenerator();
            IBattleshipsSetup testSetup = new BattleshipsSetup(testBoard, testParts, testValueGenerator);
            IBattleshipsParts expected = testParts;

            IBattleshipsParts actual = testSetup.GameParts;

            Assert.AreEqual(expected, actual, "BattleshipsSetup_BattleshipsSetup_GameParts : Incorrect value returned");
        }
        [TestMethod]
        public void BattleshipsSetup_WhenCalled_GivenValidArguments_ThenSetsValueGeneratorValue()
        {
            IBattleshipsBoard testBoard = new BattleshipsBoard();
            IBattleshipsParts testParts = new BattleshipsParts();
            IValueGenerator testValueGenerator = new ValueGenerator();
            IBattleshipsSetup testSetup = new BattleshipsSetup(testBoard, testParts, testValueGenerator);
            IValueGenerator expected = testValueGenerator;

            IValueGenerator actual = testSetup.ValueGenerator;

            Assert.AreEqual(expected, actual, "BattleshipsSetup_BattleshipsSetup_ValueGenerator : Incorrect value returned");
        }
        [TestMethod]
        public void BattleshipsSetupTests_RunSetup_WhenCalled_GivenMethodReturns_ThenAllShipsArePlaced()
        {
            IBattleshipsBoard testBoard = new BattleshipsBoard();
            IBattleshipsParts testParts = new BattleshipsParts();
            IValueGenerator testValueGenerator = new ValueGenerator();
            IBattleshipsSetup testSetup = new BattleshipsSetup(testBoard, testParts, testValueGenerator);
            int expected = testSetup.GameParts.Ships.Length;

            int actual = testSetup.GameParts.Ships.Count(Ship => Ship.Placed == false);

            Assert.AreEqual(expected, actual, "BattleshipsSetupTests_AllShipsArePlaced : Ships left unplaced");
        }
    }
}