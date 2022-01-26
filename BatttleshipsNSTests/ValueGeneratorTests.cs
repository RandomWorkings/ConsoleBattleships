﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void GetRandomLocation_ValidInputsAndOrientation1__ReturnsValidTuple()
        {
            //Arrange
            int TestSize = 10;
            int TestOrientation = 1;
            int TestLength = 4;
            ValueGenerator TestGenerator = new ValueGenerator();

            int ExpectedColMin = 0;
            int ExpectedColMax = 9; //TestSize - 1

            int ExpectedRowMin = 0;
            int ExpectedRowMax = 5; //TestSize - 1 - TestLength

            //Act
            (int actualRow, int actualColumn) = TestGenerator.GetRandomLocation(TestOrientation, TestLength, TestSize);

            //Assess
            Assert.IsTrue(ExpectedColMax >= actualColumn && actualColumn >= ExpectedColMin, "ValueGenerator - GetRandomLocation - Column value outside acceptable scope:"+actualColumn);
            Assert.IsTrue(ExpectedRowMax >= actualRow && actualRow >= ExpectedRowMin, "ValueGenerator - GetRandomLocation - Row value outside acceptable  scope:" + actualRow);

        }

        [TestMethod]
        public void GetRandomLocation_ValidInputsAndOrientation2__ReturnsValidTuple()
        {
            //Arrange
            int TestSize = 10;
            int TestOrientation = 2;
            int TestLength = 4;
            ValueGenerator TestGenerator = new ValueGenerator();

            int ExpectedColMin = 0;
            int ExpectedColMax = 5; //TestSize - 1 - TestLength

            int ExpectedRowMin = 0;
            int ExpectedRowMax = 9; //TestSize - 1

            //Act
            (int actualRow, int actualColumn) = TestGenerator.GetRandomLocation(TestOrientation, TestLength, TestSize);

            //Assess
            Assert.IsTrue(ExpectedColMax >= actualColumn && actualColumn >= ExpectedColMin, "ValueGenerator - GetRandomLocation - Column value outside acceptable scope:" + actualColumn);
            Assert.IsTrue(ExpectedRowMax >= actualRow && actualRow >= ExpectedRowMin, "ValueGenerator - GetRandomLocation - Row value outside acceptable  scope:" + actualRow);

        }

    }
}
