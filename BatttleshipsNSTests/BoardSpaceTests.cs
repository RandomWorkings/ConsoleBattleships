using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class BoardSpaceTests
    {
        [TestMethod]
        public void Occupied_WhenCalled_ReturnsDefaultValue()
        {
            bool expected = false;
            BoardSpace TestSpace = new BoardSpace();

            bool actual = TestSpace.Occupied;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Occupied : Incorrect occupied value returned"));
        }

        [TestMethod]
        public void Occupied_WhenCalled_WithValidAssignment_ReturnSameValue()
        {
            bool expected = true;
            BoardSpace TestSpace = new BoardSpace
            {
                Occupied = true
            };
            bool actual = TestSpace.Occupied;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Occupied : Incorrect occupied value returned"));
        }

        [TestMethod]
        public void Contents_WhenCalled_ReturnDefaultContents()
        {
            char? expected = null;
            BoardSpace TestSpace = new BoardSpace();

            char? actual = TestSpace.Contents;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Contents : Incorrect contents value returned"));
        }

        [TestMethod]
        public void Contents_WhenCalled_WithValidAssignment_ReturnSameValue()
        {
            char? expected = 'a';
            BoardSpace TestSpace = new BoardSpace
            {
                Contents = 'a'
            };

            char? actual = TestSpace.Contents;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Contents : Incorrect contents value returned"));
        }
    }
}