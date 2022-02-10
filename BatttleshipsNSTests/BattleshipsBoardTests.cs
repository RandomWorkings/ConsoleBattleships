using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class BattleshipsBoardTests
    {
        [TestMethod]
        public void BattleshipsBoard_BattleshipsBoard_WhenCalled_GivenNoArguments_ThenSetDefaultBoardSize()
        {
            int expected = 10;
            IBattleshipsBoard TestGrid = new BattleshipsBoard();

            int actual = TestGrid.BoardSize;

            Assert.AreEqual(expected, actual, ($@"GameBoardTests_Size : Incorrect grid size returned"));
        }

        [TestMethod]
        public void BattleshipsBoard_BattleshipsBoard_WhenCalled_GivenValidArguments_ThenSetBoardSize()
        {
            int expected = 1;
            int testSize = 1;
            IBattleshipsBoard TestGrid = new BattleshipsBoard(testSize);

            int actual = TestGrid.BoardSize;

            Assert.AreEqual(expected, actual, ($@"GameBoardTests_Size : Incorrect grid size returned"));
        }

        [TestMethod]
        public void BattleshipsBoard_BattleshipsBoard_WhenCalled_GivenNoArguments_ThenSetDefault2DArraySize()
        {
            int expected = 20;
            IBattleshipsBoard testGrid = new BattleshipsBoard();
            int arrayRows = testGrid.PlayGrid.GetLength(0);
            int arrayCols = testGrid.PlayGrid.GetLength(1);

            int actual = arrayRows + arrayCols;

            Assert.AreEqual(expected, actual, ($@"GameBoardTests_PlayGrid : 2-Dimensional array size incorrect"));
        }
        [TestMethod]
        public void BattleshipsBoard_BattleshipsBoard_WhenCalled_GivenValidArguments_ThenSet2DArraySize()
        {
            int expected = 2;
            int testSize = 1;
            IBattleshipsBoard testGrid = new BattleshipsBoard(testSize);
            int arrayRows = testGrid.PlayGrid.GetLength(0);
            int arrayCols = testGrid.PlayGrid.GetLength(1);

            int actual = arrayRows + arrayCols;

            Assert.AreEqual(expected, actual, ($@"GameBoardTests_PlayGrid : 2-Dimensional array size incorrect"));
        }

        [TestMethod]
        public void BattleshipsBoard_BattleshipsBoard_WhenCalled_GivenNoArguments_ThenSetDefault2DArrayContents()
        {
            int testSize = 10;
            IBattleshipsBoard testGrid = new BattleshipsBoard(testSize);

            IBoardSpace actual = testGrid.PlayGrid[0, 0];

            Assert.IsNotNull(actual, ($@"GameBoardTests_PlayGrid : No 2-dimensional array contents exists"));
        }
        [TestMethod]
        public void BattleshipsBoard_BattleshipsBoard_WhenCalled_GivenValidArguments_ThenSet2DArrayContents()
        {
            int testSize = 1;
            IBattleshipsBoard testGrid = new BattleshipsBoard(testSize);

            IBoardSpace actual = testGrid.PlayGrid[0, 0];

            Assert.IsNotNull(actual, ($@"GameBoardTests_PlayGrid : No 2-dimensional array contents exists"));
        }
    }
}