using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;
using System;

namespace BatttleshipsNSTests
{
    public class FakeUserIO : ConsoleIO
    {
        private static int FakeUserInput = 0;
        public override void OutputText(string s)
        {
            Console.Write(s);
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
    public class LoopIO : ConsoleIO
    {
        private static string OutIn;

        public override void OutputText(string s)
        {
            OutIn = s;
        }
        public override string InputText()
        {
            
            return OutIn;
        }
    }

    [TestClass]
    public class ConsoleIOTests
    {
        [TestMethod]
        public void ConsoleIOTests_OutputText_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
        {
            ITextIO testIO = new LoopIO();
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
