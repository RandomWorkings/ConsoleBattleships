using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ValueGeneratorTests
    {
        [TestMethod]
        public void GetRandomOrientation_WhenCalled_ReturnsAnInclusiveValueBetween1and2()
        {
            //Arrange
            ValueGenerator TestGenerator = new ValueGenerator();

            //Act
            int actual = TestGenerator.GetRandomOrientation();

            //Assess
            Assert.IsTrue(actual >= 1 && actual <= 2, "ValueGenerator - GetRandomOrientation - Value outside acceptable scope");
        }

        [TestMethod]
        public void GetRandomLocation_WithVAlidInputs_ReturnsTuple()
        {
            //Arrange
            int TestSize = 10;
            int TestOrientation = 1;
            int TestLength = 4;
            ValueGenerator TestGenerator = new ValueGenerator();

            int ExpectedSmallest = 1;
            int ExpectedLargest = 6; //TestSize - TesLength

            //Act
            (int actualColumn, int actualRow)= TestGenerator.GetRandomLocation(TestOrientation, TestLength, TestSize);

            //Assess
            Assert.IsTrue(ExpectedLargest >= actualColumn && actualColumn >= ExpectedSmallest, "ValueGenerator - GetRandomLocation - Value outside acceptable scope");
            Assert.IsTrue(ExpectedLargest >= actualRow && actualRow >= ExpectedSmallest, "ValueGenerator - GetRandomLocation - Value outside acceptable  scope");

        }
    }
}
