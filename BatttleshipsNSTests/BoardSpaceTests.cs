using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class BoardSpaceTests
    {
        [TestMethod]
        public void Occupied_WhenCalled_ReturnsDefaultValue()
        {
            bool expected = false;
            BattleshipsBoardSpace TestSpace = new BattleshipsBoardSpace();

            bool actual = TestSpace.Occupied;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Occupied : Incorrect occupied value returned"));
        }

        [TestMethod]
        public void Occupied_WhenCalled_WithValidAssignment_ReturnSameValue()
        {
            bool expected = true;
            BattleshipsBoardSpace TestSpace = new BattleshipsBoardSpace
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
            BattleshipsBoardSpace TestSpace = new BattleshipsBoardSpace();

            char? actual = TestSpace.Contents;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Contents : Incorrect contents value returned"));
        }

        [TestMethod]
        public void Contents_WhenCalled_WithValidAssignment_ReturnSameValue()
        {
            char? expected = 'a';
            BattleshipsBoardSpace TestSpace = new BattleshipsBoardSpace
            {
                Contents = 'a'
            };

            char? actual = TestSpace.Contents;

            Assert.AreEqual(expected, actual, ($@"BoardSpaceTests_Contents : Incorrect contents value returned"));
        }
    }
}