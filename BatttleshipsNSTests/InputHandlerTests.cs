using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class InputHandlerTests
    {
        [TestMethod]
        public void ValidateInput_WithValidString_ReturnsZero()
        {
            int expected = 0;
            int testBoardSize = 1;
            string testUserInput = "A1";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            int actual = inputHandler.ValidateInput(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_GetUserInput : Incorrect Input String Teturned");
        }

        [TestMethod]
        public void ValidateInput_WithWrongCharacterString_ReturnsOne()
        {
            int expected = 1;
            int testBoardSize = 1;
            string testUserInput = "B1";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            int actual = inputHandler.ValidateInput(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_ValidateInput_WrongCharacter : Incorrect Input String Teturned");
        }

        [TestMethod]
        public void ValidateInput_WithWrongIntegerString_ReturnsTwo()
        {
            int expected = 2;
            int testBoardSize = 1;
            string testUserInput = "A2";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            int actual = inputHandler.ValidateInput(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_ValidateInput_WrongInteger : Incorrect Input String Teturned");
        }

        [TestMethod]
        public void ConvertInputToTuple_WithValidString_ReturnsTuple()
        {
            (int, int) expected = (0,0);
            int testBoardSize = 1;
            string testUserInput = "A1";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            (int, int) actual = inputHandler.ConvertInputToTuple(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_ValidateInput_WrongInteger : Incorrect Input String Teturned");
        }

    }
}
