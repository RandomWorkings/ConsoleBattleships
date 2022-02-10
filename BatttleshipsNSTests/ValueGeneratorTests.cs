using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipsNS;

namespace BattleshipsNSTests
{
    [TestClass]
    public class ValueGeneratorTests
    {
        [TestMethod]
        public void ValueGenerator_GetRandomInt_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
        {
            int expected = 0;
            int testLimit = 1;
            ValueGenerator TestGenerator = new ValueGenerator();

            int actual = TestGenerator.GetRandomInt(testLimit);

            Assert.AreEqual(expected, actual, "ValueGenerator_GetRandomInt : Returned valid int");
        }

        [TestMethod]
        public void ValueGenerator_GetRandomTuple_WhenCalled_GivenValidArguments_ThenReturnsCorrectValue()
        {
            (int,int) expected = (0,0);
            int testLimit = 1;
            ValueGenerator TestGenerator = new ValueGenerator();

            (int,int) actual = TestGenerator.GetRandomTuple(testLimit,testLimit);

            Assert.AreEqual(expected, actual, "ValueGenerator_GetRandomTuple : Returned valid tuple");
        }
    }
}