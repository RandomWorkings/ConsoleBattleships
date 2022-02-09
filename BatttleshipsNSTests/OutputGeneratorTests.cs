using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class OutputGeneratorTests
    {
        [TestMethod]
        public void GenerateMessage_WithInputInvalidFormatAndNoShips_ReturnString()
        {
            OutputGenerator testOutputs = new OutputGenerator();
            int testMessagesCode = (int)Messages.Invalid_Format;
            int testSunkShipCount = 0;
            string NewLine = Environment.NewLine;
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder("");
            testBuilder.AppendLine($"{Tab}Your input is invalid.");
            testBuilder.AppendLine($"{Tab}The input was not in the correct format.");
            testBuilder.AppendLine($"{NewLine}{Tab}There are {testSunkShipCount} ship(s) left.");
            string expected = testBuilder.ToString();

            string actual = testOutputs.GenerateMessages(testMessagesCode, testSunkShipCount);        

            Assert.AreEqual(expected, actual, true, "Incorrect invalid format string ouput by generator");
        }
        [TestMethod]
        public void GenerateMessage_WithInputInvalidColumnAndNoShips_ReturnString()
        {
            OutputGenerator testOutputs = new OutputGenerator();
            int testMessagesCode = (int)Messages.Invalid_Column;
            int testSunkShipCount = 0;
            string NewLine = Environment.NewLine;
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder("");
            testBuilder.AppendLine($"{Tab}Your input is invalid.");
            testBuilder.AppendLine($"{Tab}The column letter provided doesnt exist on this grid.");
            testBuilder.AppendLine($"{NewLine}{Tab}There are {testSunkShipCount} ship(s) left.");
            string expected = testBuilder.ToString();

            string actual = testOutputs.GenerateMessages(testMessagesCode, testSunkShipCount);

            Assert.AreEqual(expected, actual, true, "Incorrect invalid column string ouput by generator");
        }
        [TestMethod]
        public void GenerateMessage_WithInputInvalidRowAndNoShips_ReturnString()
        {
            OutputGenerator testOutputs = new OutputGenerator();
            int testMessagesCode = (int)Messages.Invalid_Row;
            int testSunkShipCount = 0;
            string NewLine = Environment.NewLine;
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder("");
            testBuilder.AppendLine($"{Tab}Your input is invalid.");
            testBuilder.AppendLine($"{Tab}The row number provided doesnt exist on this grid.");
            testBuilder.AppendLine($"{NewLine}{Tab}There are {testSunkShipCount} ship(s) left.");
            string expected = testBuilder.ToString();

            string actual = testOutputs.GenerateMessages(testMessagesCode, testSunkShipCount);

            Assert.AreEqual(expected, actual, true, "Incorrect invalid row string ouput by generator");
        }
        [TestMethod]
        public void GenerateMessage_WithInputRepeatAndNoShips_ReturnString()
        {
            OutputGenerator testOutputs = new OutputGenerator();
            int testMessagesCode = (int)Messages.Repeat;
            int testSunkShipCount = 0;
            string NewLine = Environment.NewLine;
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder("");
            testBuilder.AppendLine($"{Tab}You shot at that target already.{NewLine}{Tab}You won't win the game that way.");
            testBuilder.AppendLine($"{NewLine}{Tab}There are {testSunkShipCount} ship(s) left.");
            string expected = testBuilder.ToString();

            string actual = testOutputs.GenerateMessages(testMessagesCode, testSunkShipCount);

            Assert.AreEqual(expected, actual, true, "Incorrect repeat string ouput by generator");
        }
        [TestMethod]
        public void GenerateMessage_WithInputMissedAndNoShips_ReturnString()
        {
            OutputGenerator testOutputs = new OutputGenerator();
            int testMessagesCode = (int)Messages.Missed;
            int testSunkShipCount = 0;
            string NewLine = Environment.NewLine;
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder("");
            testBuilder.AppendLine($"{Tab}You shot splashes harmlessly into the sea.{NewLine}{Tab}Maybe next time.");
            testBuilder.AppendLine($"{NewLine}{Tab}There are {testSunkShipCount} ship(s) left.");
            string expected = testBuilder.ToString();

            string actual = testOutputs.GenerateMessages(testMessagesCode, testSunkShipCount);

            Assert.AreEqual(expected, actual, true, "Incorrect missed string ouput by generator");
        }
        [TestMethod]
        public void GenerateMessage_WithHitWinnerAndNoShips_ReturnString()
        {
            OutputGenerator testOutputs = new OutputGenerator();
            int testMessagesCode = (int)Messages.Hit;
            int testSunkShipCount = 0;
                    string NewLine = Environment.NewLine;
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder("");
            testBuilder.AppendLine($"{Tab}You hit something.{NewLine}{Tab}Well done!");
            testBuilder.AppendLine($"{NewLine}{Tab}There are {testSunkShipCount} ship(s) left.");
            string expected = testBuilder.ToString();

            string actual = testOutputs.GenerateMessages(testMessagesCode, testSunkShipCount);

            Assert.AreEqual(expected, actual, true, "Incorrect hit string ouput by generator");
        }
        [TestMethod]
        public void GenerateMessage_WithInputWinnerAndNoShips_ReturnString()
        {
            OutputGenerator testOutputs = new OutputGenerator();
            int testMessagesCode = (int)Messages.Winner;
            int testSunkShipCount = 0;
            string NewLine = Environment.NewLine;
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder("");
            testBuilder.AppendLine($"{Tab}You won the game.{NewLine}{Tab}Congratulations");
            string expected = testBuilder.ToString();

            string actual = testOutputs.GenerateMessages(testMessagesCode, testSunkShipCount);

            Assert.AreEqual(expected, actual, true, "Incorrect winner string ouput by generator");
        }
        [TestMethod]
        public void GenerateMessage_WithMultipleFlagsAndOneShip_ReturnString()
        {
            OutputGenerator testOutputs = new OutputGenerator();
            int testMessagesCode = (int)Messages.Invalid_Format + (int)Messages.Invalid_Column;
            int testSunkShipCount = 1;
            string NewLine = Environment.NewLine;
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder("");
            testBuilder.AppendLine($"{Tab}Your input is invalid.");
            testBuilder.AppendLine($"{Tab}The input was not in the correct format.");
            testBuilder.AppendLine($"{Tab}The column letter provided doesnt exist on this grid.");
            testBuilder.AppendLine($"{NewLine}{Tab}There is {testSunkShipCount} ship left.");
            string expected = testBuilder.ToString();

            string actual = testOutputs.GenerateMessages(testMessagesCode, testSunkShipCount);

            Assert.AreEqual(expected, actual, true, "Incorrect mass string ouput by generator");
        }
        [TestMethod]
        public void GenerateInputRequest_ReturnString() 
        {
            OutputGenerator testOutputs = new OutputGenerator();
            string NewLine = Environment.NewLine;
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder("");
            testBuilder.AppendLine($@"{Tab}Enter Target Grid Space. Example target: A1{NewLine}{Tab}Press CRTL + C to quit");
            string expected = testBuilder.ToString();

            string actual = testOutputs.GenerateInputRequest();

            Assert.AreEqual(expected, actual, true, "Incorrect input request string ouput by generator");
        }
        [TestMethod]
        public void GeneratePlayGridUI_ReturnString()
        {
            OutputGenerator testOutputs = new OutputGenerator();
            int testSize = 1;
            GameBoard testBoard = new GameBoard(testSize);
            string Tab = "\t";
            StringBuilder testBuilder = new StringBuilder($"{Tab}    |");
/*          testBuilder.Append($" A |");
            testBuilder.AppendLine($"");
            testBuilder.Append($"{Tab}  1 |");
            testBuilder.Append($"   |");
            testBuilder.AppendLine($"");
*/
            testBuilder.Append($" A |\n{Tab}  1 |\n   |\n");

            string expected = testBuilder.ToString();

            string actual = testOutputs.GeneratePlayGridUI(testBoard);

            Assert.AreEqual(expected, actual, true, "Incorrect play grid UI string ouput by generator");
        }
    }
}
