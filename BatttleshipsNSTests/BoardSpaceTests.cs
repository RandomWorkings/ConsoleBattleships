using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class BoardSpaceTests
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
            BoardSpace TestCell = new BoardSpace(TestNumber, TestNumber);
            string expected = TestString;

            string actual = TestCell.ID;

            Assert.AreEqual(expected, actual, true, ($@"BoardSpaceTests_ID : Incorrect ID returned"));
        }
        [TestMethod]
        public void Occupied_WhenCalled_WithValidAssignment_SetCellOccupied()
        {
            BoardSpace TestCell = new BoardSpace(TestNumber, TestNumber);
            bool expected = TestOccupied;

            TestCell.Occupied = TestOccupied;
            bool actual = TestCell.Occupied;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Occupied : Incorrect Occupied value returned"));
        }
        [TestMethod]
        public void Contents_WhenCalled_WithValidAssignment_SetCellContents()
        {
            BoardSpace TestCell = new BoardSpace(TestNumber, TestNumber);
            char? expected = TestContents;

            TestCell.Contents = TestContents;
            char? actual = TestCell.Contents;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Contents : Incorrect Contents value returned"));
        }


        [TestMethod]
        public void BoardSpace_WhenCalled__WithValidParameters_InitializeDefaultCellValues()
        {
            BoardSpace TestSpace = new BoardSpace(TestNumber, TestLetter);
            bool expectedOccupied = false;
            char? expectedContents = null;

            bool actualOccupied = TestSpace.Occupied;
            char? actualContents = TestSpace.Contents;

            Assert.AreEqual(expectedOccupied, actualOccupied, ($@"BoardSpaceTests_BoardSpace : Incorrect Default Occupied returned"));
            Assert.AreEqual(expectedContents, actualContents, ($@"BoardSpaceTests_BoardSpace : Incorrect Default Contents returned"));
        }
        
    }
}
