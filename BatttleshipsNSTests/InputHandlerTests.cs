using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    public class FakeUserInput : IUserInput
    {
        public string GetUserInput()
        { return "A1"; }
    }

    [TestClass]
    public class InputHandlerTests
    {
        [TestMethod]
        public void GetTargetSpace_WhenInputHandlerCreatedWithSingleIntger_WithNoArguments_ReturnsTargetSpace()
        {
            int[] expected = {0, 0, 0, 0, 0};
            int testBoardSize = 1;
            new InputHandler(testBoardSize)



            string actual = TestSpace.ID;

            Assert.AreEqual(expected, actual, true, ($@"BoardSpaceTests_ID : Incorrect ID returned"));
        }


        public void GetUserInput_WhenCalled_WithNoArguments_ReturnString()
        {
            string expected = "A1";
            int testBoardSize = 1;
            InputHandler inputHandler = new InputHandler(testBoardSize);

            string actual = inputHandler.GetUserInput();

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_GetUserInput : Incorrect Input String Teturned");
        }

        public void ValidateInput_WithValidString_ReturnsZero()
        {
            int expected = 0;
            int testBoardSize = 1;
            string testUserInput = "A1";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            int actual = inputHandler.ValidateInput(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_GetUserInput : Incorrect Input String Teturned");
        }
        public void ValidateInput_WithWrongLengthString_ReturnsOne()
        {
            int expected = 1;
            int testBoardSize = 1;
            string testUserInput = "AA0";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            int actual = inputHandler.ValidateInput(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_GetUserInput : Incorrect Input String Teturned");
        }
        public void ValidateInput_WithWrongCharacterString_ReturnsTwo()
        {
            int expected = 2;
            int testBoardSize = 1;
            string testUserInput = "B1";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            int actual = inputHandler.ValidateInput(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_GetUserInput : Incorrect Input String Teturned");
        }
        public void ValidateInput_WithWrongIntegerString_ReturnsFour()
        {
            int expected = 0;
            int testBoardSize = 1;
            string testUserInput = "A1";
            InputHandler inputHandler = new InputHandler(testBoardSize);

            int actual = inputHandler.ValidateInput(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_GetUserInput : Incorrect Input String Teturned");
        }

        public void ConvertInputToTuple_WithValidString_ReturnsTuple()
        {
            (int, int) expected = (0,0);
        }


        string GetUserInput()
        int ValidateInput(string userInput)
        (int, int) ConvertInputToTuple(string userInput)
    }
}
