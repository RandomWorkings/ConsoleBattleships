using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class GridTests
    {
        //Common Test Variables
        private readonly int testSize = 100;

        [TestMethod]
        public void Size_WhenCalled_WithoutArguments_ShouldGetSize()
        {
            //Arrange
            int expected = testSize;
            Grid TestGrid = new Grid(testSize);

            //Act
            int actual = TestGrid.Size;

            //Assess
            Assert.AreEqual(expected, actual, ($@"GridTests_Size : Incorrect Grid Size Returned : actual [{actual}], expected [{expected}]"));
        }

        [TestMethod]

        public void PlayGrid_WhenCalled_WithValidArguments_ShouldGet2DArrayOfGridCells()
        {
            //Arrange
            int expectedRank = 2;
            int expectedRowCount = testSize;
            int expectedColCount = testSize;
            Grid TestGrid = new Grid(testSize);

            //Act
            int actualRank = TestGrid.PlayGrid.Rank;
            int actualRowCount = TestGrid.PlayGrid.GetLength(0);
            int actualColCount = TestGrid.PlayGrid.GetLength(actualRank - 1);

            //Assess
            Assert.AreEqual(expectedRank, actualRank, ($@"GridTests_Grid : Incorrect Multi Dimensional Array Rank Returned : actual [{actualRank}], expected [{expectedRank}"));
            Assert.AreEqual(expectedRowCount, actualRowCount, ($@"GridTests_Grid : Incorrect Multi Dimensional Array Rows Count Returned : actual [{actualRowCount}], expected [{expectedRowCount}]"));
            Assert.AreEqual(expectedColCount, actualColCount, ($@"GridTests_Grid : Incorrect Multi Dimensional Array Columns Count Returned : actual [{actualColCount}], expected [{expectedColCount}]"));

            for (int row = 0; row < testSize; row++)
            {
                for (int col = 0; col < testSize; col++)
                {
                    Assert.IsInstanceOfType((TestGrid.PlayGrid[row,col]), typeof(GridCell), ($@"GridTests_Grid: Incorrect Array Contents Type Returned"));
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
