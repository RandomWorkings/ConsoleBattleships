﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class InputHandlerTests
    {
        [TestMethod]
        public void ValidateInput_WithValidString_ReturnsInt()
        {
            int expected = 0;
            int testBoardSize = 1;
            string testUserInput = "A1";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            int actual = inputHandler.ValidateInput(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_GetUserInput : Incorrect Input String Teturned");
        }

        [TestMethod]
        public void ValidateInput_WithWrongCharacterString_ReturnsInt()
        {
            int expected = (int)Messages.Invalid_Column;
            int testBoardSize = 1;
            string testUserInput = "B1";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            int actual = inputHandler.ValidateInput(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_ValidateInput_WrongCharacter : Incorrect Input String Teturned");
        }

        [TestMethod]
        public void ValidateInput_WithWrongIntegerString_ReturnsInt()
        {
            int expected = (int)Messages.Invalid_Row;
            int testBoardSize = 1;
            string testUserInput = "A2";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            int actual = inputHandler.ValidateInput(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_ValidateInput_WrongInteger : Incorrect Input String Teturned");
        }

        [TestMethod]
        public void ConvertInputToTuple_WithValidString_ReturnsTuple()
        {
            (int, int) expected = (0, 0);
            int testBoardSize = 1;
            string testUserInput = "A1";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            (int, int) actual = inputHandler.ConvertInputToTuple(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_ValidateInput_WrongInteger : Incorrect Input String Teturned");
        }

    }
}