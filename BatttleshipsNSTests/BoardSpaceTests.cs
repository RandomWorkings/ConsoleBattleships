using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class BoardSpaceTests
    {
        [TestMethod]
        public void BoardSpaceTests_PropertyOccupied_WhenCalled_GivenNoArguments_ThenReturnsDefaultValue()
        {
            bool expected = false;
            BoardSpace TestSpace = new BoardSpace();

            bool actual = TestSpace.Occupied;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Occupied : Incorrect occupied value returned"));
        }

        [TestMethod]
        public void BoardSpaceTests_PropertyOccupied_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
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
        public void BoardSpaceTests_Contents_WhenCalled_GivenNoArguments_ThenReturnsDefaultValue()
        {
            char? expected = null;
            BoardSpace TestSpace = new BoardSpace();

            char? actual = TestSpace.Contents;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Contents : Incorrect contents value returned"));
        }

        [TestMethod]
        public void BoardSpaceTests_Contents_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
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