using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class InputHandlerTests
    {
        [TestMethod]
        public void ValidateInput_WithValidInput_ReturnsTrue()
        {
            //Arrange
            int gridSize = 10;
            InputHandler Inputs = new InputHandler();
            string testInput = "A1";
            bool expected = true;

            //Act
            var actual = Inputs.ValidateInput(gridSize, testInput);

            //Assess
            Assert.AreEqual(expected, actual, "Test input incorrecly validated - False when True");
        }

        [TestMethod]
        public void ValidateInput_WithInvalidInput_ReturnsFalse()
        {
            //Arrange
            int gridSize = 10;
            InputHandler Inputs = new InputHandler();
            bool expected = false;

            //Act
            string testInput = "Butts";
            var actual = Inputs.ValidateInput(gridSize, testInput);

            //Assess
            Assert.AreEqual(expected, actual, "Test input incorrecly validated - True when False");
        }
    }
}
