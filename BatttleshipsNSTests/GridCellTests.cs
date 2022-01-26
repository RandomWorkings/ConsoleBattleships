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
            string expectedID = "A1";
            char? expectedContents = null;
            GridCell TestCell = new GridCell('A', 1);

            //Act
            string actualID = TestCell.ID;
            char? actualContents = TestCell.Contents;

            //Assess
            Assert.AreEqual(expectedID, actualID, true , "GridCellTests - GridCell - ID incorrecly set");          
            Assert.AreEqual(expectedContents, actualContents, "GridCellTests - GridCell - Contents incorrecly set");
        }
        [TestMethod]
        public void Contents_WhenInputIsValid_ShouldSet()
        {
            //Arrange
            char expectedContents = 'o';
            GridCell TestCell = new GridCell('A', 1);
            {
                TestCell.Contents = 'o';
            }
            //Act

            //Assess
            char? actualContents = TestCell.Contents;
            Assert.AreEqual(expectedContents, actualContents, "GridCellTests - Contents - Contents incorrecly set");
        }
    }
}
