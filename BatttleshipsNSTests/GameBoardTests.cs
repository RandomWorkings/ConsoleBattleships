using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class GameBoardTests
    {
        //Shared Test Inputs
        private static readonly int TestSize = 10;

        [TestMethod]
        public void BoardSize_WhenCalled_WithoutArguments_GetSize()
        {
            int expected = TestSize;
            GameBoard TestGrid = new GameBoard(TestSize);

            int actual = TestGrid.BoardSize;

            Assert.AreEqual(expected, actual, ($@"PlayGridTests_Size : Incorrect Grid Size Returned"));
        }
        [TestMethod]
        public void GameBoard_WhenCalled_WithValidArguments_GetPlayGrid()
        {
            int expectedRank = 2;
            int expectedRowCount = TestSize;
            int expectedColCount = TestSize;
            GameBoard TestGrid = new GameBoard(TestSize);

            int actualRank = TestGrid.PlayGrid.Rank;
            int actualRowCount = TestGrid.PlayGrid.GetLength(0);
            int actualColCount = TestGrid.PlayGrid.GetLength(actualRank - 1);

            Assert.AreEqual(expectedRank, actualRank, ($@"PlayGridTests_PlayGrid : Incorrect 2-Dimensional Array rank returned"));
            Assert.AreEqual(expectedRowCount, actualRowCount, ($@"PlayGridTests_PlayGrid : Incorrect 2-Dimensional Array rows count"));
            Assert.AreEqual(expectedColCount, actualColCount, ($@"PlayGridTests_PlayGrid : Incorrect 2-Dimensional Array columns count"));
            for (int row = 0; row < TestSize; row++)
            {
                for (int col = 0; col < TestSize; col++)
                {
                    Assert.IsInstanceOfType((TestGrid.PlayGrid[row,col]), typeof(BoardSpace), ($@"PlayGridTests_PlayGrid: Incorrect 2-Dimensional Array Contents Type returned"));
                }
            }
        }


        /*Code To Test Not Implemented*/
        [TestMethod]
        public void GetTargetBoardSpace_WhenValidInput_GetTargetGridCell()
        {
            //Arrange

            //Act

            //Assess
            //Assert.AreEqual(expected, actual, ($@"CLASS_METHOD : ERROR"));
        }

        
    }
}
