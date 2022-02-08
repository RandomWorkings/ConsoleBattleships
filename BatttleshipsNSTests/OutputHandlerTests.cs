using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class OutputHandlerTests
    {
/*        [DataTestMethod]
        [DataRow(1, 0, "\tYour input is invalid.\n\tIt was not the correct format.\n")]
        [DataRow(2, 0, "\tYour input is invalid.\n\tThe column letter provided doesnt exist on this grid.\n")]
        [DataRow(4, 0, "\tYour input is invalid.\n\tThe row number provided doesnt exist on this grid.\n")]
        [DataRow(8, 0, "\tYou shot at that target already.\n\tYou won't win the game that way.\n")]
        [DataRow(16, 0, "\tYou shot splashes harmlessly into the sea.\n\tMaybe next time.\n")]
        [DataRow(32, 0, "\tYou hit something.\n\tWell done!\n")]
        [DataRow(64, 0, "\tYou won the game.\n\tCongratulations\n")]
        public void GenerateMessage_WithValidArguments_ReturnString(int testMessagesCode, int testSunkShipCount, string expected)
        {
            ConsoleIO ConsoleIO = new ConsoleIO();
            OutputGenerator testOutputs = new OutputGenerator();
            testOutputs.GenerateMessages(testMessagesCode, testSunkShipCount);
            

            Assert.AreEqual(expected, actual, true, "Correct message ouput to console");
        }
*/
    }
}
