using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class GridTests
    {
        //Shared Test Inputs
        private static readonly int testSize = 10;

        [TestMethod]
        public void Size_WhenCalled_WithoutArguments_ShouldGetSize()
        {
            int expected = testSize;
            Grid TestGrid = new Grid(testSize);

            int actual = TestGrid.Size;

            Assert.AreEqual(expected, actual, ($@"GridTests_Size : Incorrect Grid Size Returned"));
        }

        [TestMethod]

        public void PlayGrid_WhenCalled_WithValidArguments_ShouldGet2DArrayOfGridCells()
        {
            int expectedRank = 2;
            int expectedRowCount = testSize;
            int expectedColCount = testSize;
            Grid TestGrid = new Grid(testSize);

            int actualRank = TestGrid.PlayGrid.Rank;
            int actualRowCount = TestGrid.PlayGrid.GetLength(0);
            int actualColCount = TestGrid.PlayGrid.GetLength(actualRank - 1);

            Assert.AreEqual(expectedRank, actualRank, ($@"GridTests_PlayGrid : Incorrect 2-Dimensional Array rank returned"));
            Assert.AreEqual(expectedRowCount, actualRowCount, ($@"GridTests_PlayGrid : Incorrect 2-Dimensional Array rows count"));
            Assert.AreEqual(expectedColCount, actualColCount, ($@"GridTests_PlayGrid : Incorrect 2-Dimensional Array columns count"));
            for (int row = 0; row < testSize; row++)
            {
                for (int col = 0; col < testSize; col++)
                {
                    Assert.IsInstanceOfType((TestGrid.PlayGrid[row,col]), typeof(GridCell), ($@"GridTests_PlayGrid: Incorrect 2-Dimensional Array Contents Type returned"));
                }
            }
        }

        [TestMethod]
        public void GetTargetGridCell_WhenValidInput_ShouldReturnGridCell()
        {
            //Arrange

            //Act

            //Assess
            //Assert.AreEqual(expectedContents, actualContents, "GridCellTests - Contents - Contents incorrecly set");
        }

        
    }
}
