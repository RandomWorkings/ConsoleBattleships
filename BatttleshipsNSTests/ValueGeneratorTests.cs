using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ValueGeneratorTests
    {
        //Shared Test Inputs
        private static readonly int TestGridSize = 10;
        private static readonly int TestShipLength = 4;

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
        public void GetRandomLocation_ValidInputsAndOrientation1__ReturnsValidTuple()
        {
            ValueGenerator TestGenerator = new ValueGenerator();
            int TestOrientation = 1; //Horizontal, Step through Columns      
            int ExpectedColMin = 0;
            int ExpectedColMax = TestGridSize - TestShipLength - 1;
            int ExpectedRowMin = 0;
            int ExpectedRowMax = TestGridSize - 1;

            (int actualRow, int actualColumn) = TestGenerator.GetRandomLocation(TestOrientation, TestShipLength, TestGridSize);

            Assert.IsTrue(ExpectedRowMax >= actualRow && actualRow >= ExpectedRowMin, ($@"ValueGenerator_GetRandomLocation : Returned incorrect Firdt Tuple value")); 
            Assert.IsTrue(ExpectedColMax >= actualColumn && actualColumn >= ExpectedColMin, ($@"ValueGenerator_GetRandomLocation : Returned incorrect Second Tuple value"));
        }

        [TestMethod]
        public void GetRandomLocation_ValidInputsAndOrientation2__ReturnsValidTuple()
        {
            ValueGenerator TestGenerator = new ValueGenerator();
            int TestOrientation = 2; //Vertical, Step through Rows
            int ExpectedColMin = 0;
            int ExpectedColMax = TestGridSize - 1;
            int ExpectedRowMin = 0;
            int ExpectedRowMax = TestGridSize - TestShipLength - 1;

            (int actualRow, int actualColumn) = TestGenerator.GetRandomLocation(TestOrientation, TestShipLength, TestGridSize);

            Assert.IsTrue(ExpectedRowMax >= actualRow && actualRow >= ExpectedRowMin, ($@"ValueGenerator_GetRandomLocation : Returned incorrect Firdt Tuple value"));
            Assert.IsTrue(ExpectedColMax >= actualColumn && actualColumn >= ExpectedColMin, ($@"ValueGenerator_GetRandomLocation : Returned incorrect Second Tuple value"));
        }

    }
}