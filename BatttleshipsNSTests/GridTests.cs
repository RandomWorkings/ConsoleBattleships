using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class GridTests
    {
        //Shared Test Inputs
        private static readonly int TestSize = 10;

        [TestMethod]
        public void Size_WhenCalled_WithoutArguments_GetSize()
        {
            int expected = TestSize;
            Grid TestGrid = new Grid(TestSize);

            int actual = TestGrid.Size;

            Assert.AreEqual(expected, actual, ($@"GridTests_Size : Incorrect Grid Size Returned"));
        }
        [TestMethod]
        public void PlayGrid_WhenCalled_WithValidArguments_GetPlayGrid()
        {
            int expectedRank = 2;
            int expectedRowCount = TestSize;
            int expectedColCount = TestSize;
            Grid TestGrid = new Grid(TestSize);

            int actualRank = TestGrid.PlayGrid.Rank;
            int actualRowCount = TestGrid.PlayGrid.GetLength(0);
            int actualColCount = TestGrid.PlayGrid.GetLength(actualRank - 1);

            Assert.AreEqual(expectedRank, actualRank, ($@"GridTests_PlayGrid : Incorrect 2-Dimensional Array rank returned"));
            Assert.AreEqual(expectedRowCount, actualRowCount, ($@"GridTests_PlayGrid : Incorrect 2-Dimensional Array rows count"));
            Assert.AreEqual(expectedColCount, actualColCount, ($@"GridTests_PlayGrid : Incorrect 2-Dimensional Array columns count"));
            for (int row = 0; row < TestSize; row++)
            {
                for (int col = 0; col < TestSize; col++)
                {
                    Assert.IsInstanceOfType((TestGrid.PlayGrid[row,col]), typeof(GridCell), ($@"GridTests_PlayGrid: Incorrect 2-Dimensional Array Contents Type returned"));
                }
            }
        }


        /*Code To Test Not Implemented*/
        [TestMethod]
        public void GetTargetGridCell_WhenValidInput_GetTargetGridCell()
        {
            //Arrange

            //Act

            //Assess
            //Assert.AreEqual(expected, actual, ($@"CLASS_METHOD : ERROR"));
        }

        
    }
}
