using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class BoardSpaceTests
    {
        [TestMethod]
        public void ID_WhenSpaceCreatedWithNoArguments_WithNoArguments_ReturnsID()
        {
            string expected = "A1";
            BoardSpace TestSpace = new BoardSpace();

            string actual = TestSpace.ID;

            Assert.AreEqual(expected, actual, true, ($@"BoardSpaceTests_ID : Incorrect ID returned"));
        }
        public void ID_WhenSpaceCreatedWithTwoInts_WithNoArguments_ReturnsID()
        {
            string expected = "A1";
            int row = 0;
            int column = 0;
            BoardSpace TestSpace = new BoardSpace(row, column);

            string actual = TestSpace.ID;

            Assert.AreEqual(expected, actual, true, ($@"BoardSpaceTests_ID : Incorrect ID returned"));
        }
        [TestMethod]
        public void Occupied_WhenSpaceCreatedWithNoArguments_WithNoArguments_ReturnsOccupied()
        {
            bool expected = false;
            BoardSpace TestSpace = new BoardSpace();

            bool actual = TestSpace.Occupied;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Occupied : Incorrect Occupied value returned"));
        }
        [TestMethod]
        public void Occupied_WhenSpaceCreatedWithTwoInts_WithNoArguments_ReturnsOccupied()
        {
            bool expected = false;
            int row = 0;
            int column = 0;
            BoardSpace TestSpace = new BoardSpace(row, column);

            bool actual = TestSpace.Occupied;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Occupied : Incorrect Occupied value returned"));
        }
        [TestMethod]
        public void Occupied_WhenSpaceCreatedWithNoArguments_WithSingleBool_ReturnsSameOccupied()
        {
            bool expected = true;
            BoardSpace TestSpace = new BoardSpace();
            TestSpace.Occupied = true;

            bool actual = TestSpace.Occupied;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Occupied : Incorrect Occupied value returned"));
        }
        [TestMethod]
        public void Occupied_WhenSpaceCreatedWithTwoInts_WithSingleBool_ReturnsSameOccupied()
        {
            bool expected = true;
            int row = 0;
            int column = 0;
            BoardSpace TestSpace = new BoardSpace(row, column);
            TestSpace.Occupied = true;

            bool actual = TestSpace.Occupied;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Occupied : Incorrect Occupied value returned"));
        }
        [TestMethod]
        public void Contents_WhenSpaceCreatedWithNoArguments_WithNoArguments_ReturnsContents()
        {
            char? expected = null;
            BoardSpace TestSpace = new BoardSpace();

            char? actual = TestSpace.Contents;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Contents : Incorrect Contents value returned"));
        }
        [TestMethod]
        public void Contents_WhenCellCreatedWithTwoInts_WithNoArguments_ReturnsContents()
        {
            char? expected = null;
            int row = 0;
            int column = 0;
            BoardSpace TestCell = new BoardSpace(row, column);

            char? actual = TestCell.Contents;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Contents : Incorrect Contents value returned"));
        }
        [TestMethod]
        public void Contents_WhenCellCreatedWithNoArguments_WithSingleChar_ReturnsSameContents()
        {
            char? expected = 'a';
            BoardSpace TestSpace = new BoardSpace();
            TestSpace.Contents = 'a';

            char? actual = TestSpace.Contents;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Contents : Incorrect Contents value returned"));
        }
        [TestMethod]
        public void Contents_WhenCellCreatedWithTwoInts_WithSingleChar_ReturnsSameContents()
        {
            char? expected = 'a';
            int row = 0;
            int column = 0;
            BoardSpace TestSpace = new BoardSpace(row, column);
            TestSpace.Contents = 'a';

            char? actual = TestSpace.Contents;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Contents : Incorrect Contents value returned"));
        }
    }
}
