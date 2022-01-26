using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class GridCellTests
    {
        //Shared Test Inputs
        private static readonly bool TestOccupied = true;
        private static readonly char TestLetter = 'A';
        private static readonly char? TestContents = 'x';
        private static readonly int TestNumber = 1;
        private static readonly string TestString = ""+TestLetter+TestNumber;

        [TestMethod]
        public void ID_WhenCalled_GetCellID()
        {
            GridCell TestCell = new GridCell(TestNumber, TestLetter);
            string expected = TestString;

            string actual = TestCell.ID;

            Assert.AreEqual(expected, actual, true, ($@"GridCellTests_ID : Incorrect ID returned"));
        }
        [TestMethod]
        public void Occupied_WhenCalled_WithValidAssignment_SetCellOccupied()
        {
            GridCell TestCell = new GridCell(TestNumber, TestLetter);
            bool expected = TestOccupied;

            TestCell.Occupied = TestOccupied;
            bool actual = TestCell.Occupied;

            Assert.AreEqual(expected, actual, ($@"GridCellTests_Occupied : Incorrect Occupied value returned"));
        }
        [TestMethod]
        public void Contents_WhenCalled_WithValidAssignment_SetCellContents()
        {
            GridCell TestCell = new GridCell(TestNumber, TestLetter);
            char? expected = TestContents;

            TestCell.Contents = TestContents;
            char? actual = TestCell.Contents;

            Assert.AreEqual(expected, actual, ($@"GridCellTests_Contents : Incorrect Contents value returned"));
        }


        [TestMethod]
        public void GridCell_WhenCalled__WithValidParameters_InitializeDefaultCellValues()
        {
            GridCell TestCell = new GridCell(TestNumber, TestLetter);
            bool expectedOccupied = false;
            char? expectedContents = null;

            bool actualOccupied = TestCell.Occupied;
            char? actualContents = TestCell.Contents;

            Assert.AreEqual(expectedOccupied, actualOccupied, ($@"GridCellTests_GridCell : Incorrect Default Occupied returned"));
            Assert.AreEqual(expectedContents, actualContents, ($@"GridCellTests_GridCell : Incorrect Default Contents returned"));
        }
        
    }
}
