using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class GridCellTests
    {
        [TestMethod]
        public void GridCell_WhenCalledWithValidInputs_ShouldSetID()
        {
            //Arrange
            int testRow = 1;
            char testColumn = 'A';
            string expected = "A1";

            //Act
            GridCell TestCell = new GridCell(testRow, testColumn);
                       
            //Assess
            string actual = TestCell.ID;
            Assert.AreEqual(expected, actual, true , "GridCells Test - ID incorrecly set");
        }
    }
}
