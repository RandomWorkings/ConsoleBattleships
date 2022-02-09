using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class GameBoardTests
    {
        [TestMethod]
        public void GameBoard_WhenCalled_WithValidArguments_SetBoardSize()
        {
            int expected = 1;
            int testSize = 1;
            BattleshipsBoard TestGrid = new BattleshipsBoard(testSize);

            int actual = TestGrid.BoardSize;

            Assert.AreEqual(expected, actual, ($@"GameBoardTests_Size : Incorrect grid size returned"));
        }

        [TestMethod]
        public void GameBoard_WhenCalled_WithValidArguments_Set2DArraySize()
        {
            int expected = 2;
            int testSize = 1;
            BattleshipsBoard testGrid = new BattleshipsBoard(testSize);
            int arrayRows = testGrid.PlayGrid.GetLength(0);
            int arrayCols = testGrid.PlayGrid.GetLength(1);

            int actual = arrayRows + arrayCols;

            Assert.AreEqual(expected, actual, ($@"GameBoardTests_PlayGrid : 2-Dimensional array size incorrect"));
        }

        [TestMethod]
        public void GameBoard_WhenCalled_WithValidArguments_Set2DArrayContents()
        {
            int testSize = 1;
            BattleshipsBoard testGrid = new BattleshipsBoard(testSize);

            BattleshipsBoardSpace actual = testGrid.PlayGrid[0, 0];

            Assert.IsNotNull(actual, ($@"GameBoardTests_PlayGrid : No 2-dimensional array contents exists returned"));
        }
    }
}