using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    [TestClass]
    public class ValueGeneratorTests
    {
        [TestMethod]
        public void GetRandomInt_WhenCalled_WithValidArguments_ReturnsAnInt()
        {
            int expected = 0;
            int testLimit = 1;
            ValueGenerator TestGenerator = new ValueGenerator();

            int actual = TestGenerator.GetRandomInt(testLimit);

            Assert.AreEqual(expected, actual, "ValueGenerator_GetRandomInt : Returned valid int");
        }

        [TestMethod]
        public void GetRandomTuple_WhenCalled_WithValidArguments_ReturnsATuple()
        {
            (int,int) expected = (0,0);
            int testLimit = 1;
            ValueGenerator TestGenerator = new ValueGenerator();

            (int,int) actual = TestGenerator.GetRandomTuple(testLimit,testLimit);

            Assert.AreEqual(expected, actual, "ValueGenerator_GetRandomTuple : Returned valid tuple");
        }
    }
}