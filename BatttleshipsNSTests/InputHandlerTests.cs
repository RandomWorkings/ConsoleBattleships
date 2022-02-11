using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class InputHandlerTests
    {
        [DataTestMethod]
        [DataRow(0,"A1",1,"InputHandlerTests_ValidateInput_ValidString : Incorrect value returned")]
        [DataRow((int)Messages.Invalid_Format, "A1#1a", 1, "InputHandlerTests_ValidateInput_IncorrectFormat : Incorrect value returned")]
        [DataRow((int)Messages.Invalid_Column, "B1", 1, "InputHandlerTests_ValidateInput_IncorrectColumn : Incorrect value returned")]
        [DataRow((int)Messages.Invalid_Row, "A2", 1, "InputHandlerTests_ValidateInput_IncorrectRow : Incorrect value returned")]
        public void InputHandlerTests_ValidateInput_WhenCalled_GivenArgument_ThenReturnCorrectValue(int expected, string testUserInput, int testBoardSize, string failMessage)
        {
            IInputHandler inputHandler = new InputHandler(testBoardSize);

            Messages actual = inputHandler.ValidateInput(testUserInput);

            Assert.AreEqual(expected, actual, failMessage);
        }
        [TestMethod]
        public void ConvertInputToTuple_WhenCalled_GivenValidArgument_ThenReturnCorrectValue()
        {
            (int, int) expected = (0, 0);
            int testBoardSize = 1;
            string testUserInput = "A1";
            IInputHandler inputHandler = new InputHandler(testBoardSize);

            (int, int) actual = inputHandler.ConvertInputToTuple(testUserInput);

            Assert.AreEqual(expected, actual, $@"InputHandlerTests_ValidateInput_WrongInteger : Incorrect Input String Teturned");
        }

    }
}