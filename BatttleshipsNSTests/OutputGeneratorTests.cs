using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class OutputGeneratorTests
    {
        [DataTestMethod]
        [DataRow(Messages.Invalid_Format, 0, "\tYour input is invalid.\n\tThe input was not in the correct format.\n\n\tThere are 0 ship(s) left.\n", "Incorrect invalid format string ouput by generator")]
        [DataRow(Messages.Invalid_Column, 0, "\tYour input is invalid.\n\tThe column letter provided doesnt exist on this grid.\n\n\tThere are 0 ship(s) left.\n", "Incorrect invalid column string ouput by generator")]
        [DataRow(Messages.Invalid_Row, 0, "\tYour input is invalid.\n\tThe row number provided doesnt exist on this grid.\n\n\tThere are 0 ship(s) left.\n", "Incorrect invalid row string ouput by generator")]
        [DataRow(Messages.Repeat, 0, "\tYou shot at that target already.\n\tYou won't win the game that way.\n\n\tThere are 0 ship(s) left.\n", "Incorrect repeat string ouput by generator")]
        [DataRow(Messages.Missed, 0, "\tYou shot splashes harmlessly into the sea.\n\tMaybe next time.\n\n\tThere are 0 ship(s) left.\n", "Incorrect missed string ouput by generator")]
        [DataRow(Messages.Hit, 0, "\tYou hit something.\n\tWell done!\n\n\tThere are 0 ship(s) left.\n", "Incorrect hit string ouput by generator")]
        [DataRow(Messages.Sunk, 0, "\n\tYou sunk a vessel.\n\n\tThere are 0 ship(s) left.\n", "Incorrect sunk string ouput by generator")]
        [DataRow(Messages.Winner, 0, "\tYou won the game.\n\tCongratulations\n", "Incorrect winner string ouput by generator")]
        [DataRow((Messages.Invalid_Format | Messages.Invalid_Column), 1,
            "\tYour input is invalid.\n\tThe input was not in the correct format.\n\tThe column letter provided doesnt exist on this grid.\n\n\tThere is 1 ship left.\n", "Incorrect mass string ouput by generator")]
        public void DataTest_OutputGenerator_GenerateFeedbackMessage_WhenCalled_WithValidArguments_ReturnCorrectString(Messages testMessagesCode, int testShipCount, string expectedAlmost, string failMessage)
        {
            IOutputGenerator testOutputs = new OutputGenerator();
            string expected = expectedAlmost.Replace("\n", "\r\n");

            string actual = testOutputs.GenerateFeedbackMessage(testMessagesCode, testShipCount);

            Assert.AreEqual(expected, actual, true, failMessage);
        }

        [TestMethod]
        public void OutputGenerator_GenerateInputRequestMessage_WhenCalled_WithValidArguments_ThenReturnCorrectString() 
        {
            IOutputGenerator testOutputs = new OutputGenerator();
            string NewLine = Environment.NewLine;
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder("");
            testBuilder.AppendLine($@"{Tab}Enter Target Grid Space. Example target: A1{NewLine}{Tab}Press CRTL + C to quit");
            string expected = testBuilder.ToString();

            string actual = testOutputs.GenerateInputRequestMessage();

            Assert.AreEqual(expected, actual, true, "Incorrect input request string ouput by generator");
        }

        [TestMethod]
        public void OutputGenerator_GenerateGameUI_WhenCalled_WithValidArguments_ThenReturnCorrectString()
        {
            IOutputGenerator testOutputs = new OutputGenerator();
            int testSize = 1;
            IBattleshipsBoard testBoard = new BattleshipsBoard(testSize);
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder($"{Tab}    |");
            testBuilder.Append($" A |");
            testBuilder.AppendLine($"");
            testBuilder.Append($"{Tab}  1 |");
            testBuilder.Append($"   |");
            testBuilder.AppendLine($"");

            string expected = testBuilder.ToString();

            string actual = testOutputs.GenerateGameUI(testBoard);

            Assert.AreEqual(expected, actual, true, "Incorrect play grid UI string ouput by generator");
        }
    }
}