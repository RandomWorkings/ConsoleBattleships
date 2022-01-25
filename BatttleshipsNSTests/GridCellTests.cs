using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class GridCellTests
    {
        [TestMethod]
        public void GridCell_WhenCalledWithValidInputs_ShouldSetIDAndContents()
        {
            //Arrange
            int testRow = 1;
            char testColumn = 'A';
            string expectedID = "A1";
            char expectedContents = ' ';

            //Act
            GridCell TestCell = new GridCell(testRow, testColumn);
                       
            //Assess
            string actualID = TestCell.ID;
            Assert.AreEqual(expectedID, actualID, true , "GridCells Test - ID incorrecly set");
            
            char actualContents = TestCell.Contents;
            Assert.AreEqual(expectedContents, actualContents, "GridCells Test - Contents incorrecly set");
        }
    }
}
