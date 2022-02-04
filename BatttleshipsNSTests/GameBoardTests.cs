using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class GameBoardTests
    {
        [TestMethod]
        public void GameBoard_WhenCalled_WithValidArguments_SetSize()
        {
            int expected = 1;
            int testSize = 1;
            GameBoard TestGrid = new GameBoard(testSize);

            int actual = TestGrid.BoardSize;

            Assert.AreEqual(expected, actual, ($@"GameBoardTests_Size : Incorrect Grid Size Returned"));
        }

        [TestMethod]
        public void GameBoard_WhenCalled_WithValidArguments_Set2DArrayContents()
        {
            int testSize = 1;
            GameBoard testGrid = new GameBoard(testSize);

            BoardSpace actual = testGrid.PlayGrid[0,0];

            Assert.IsNotNull(actual, ($@"GameBoardTests_PlayGrid : No 2-Dimensional Array Contents exists returned"));
        }
    }
}
