using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    public class FakeUserIO : ConsoleIO
    {
        private static int FakeUserInput = 0;
        public override void OutputText(string s)
        {
        }
        public override string InputText()
        {
            if (FakeUserInput >= 1) { FakeUserInput = 0; }
            string[] ReturnList = { "goodbye" };
            string fakeUserInput = ReturnList[FakeUserInput];
            FakeUserInput++;
            return fakeUserInput;
        }
    }
    [TestClass]
    public class ConsoleIOTests
    {
        [TestMethod]
        public void ConsoleIOTests_OutputText_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
        {
            ITextIO testIO = new ConsoleIO();
            string expected = "hello";

            testIO.OutputText(expected);
            string actual = testIO.InputText();

            Assert.AreEqual(expected, actual, ($@"ConsoleIOTests_OutputInputText : Incorrect output value returned"));
        }

        [TestMethod]
        public void ConsoleIOTests_InputText_WhenCalled_GivenNoArguments_ThenReturnsCorrectValue()
        {
            ITextIO testIO = new FakeUserIO();
            string expected = "goodbye";

            string actual = testIO.InputText();

            Assert.AreEqual(expected, actual, ($@"ConsoleIOTests_OutputInputText : Incorrect value returned"));
        }

    }
}
