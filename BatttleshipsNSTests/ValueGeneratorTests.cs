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
            Assert.IsTrue(actual <= 2 && actual >= 1, "ValueGenerator - GetRandomOrientation - Value outside scope");
        }

/*        [TestMethod]
        public void GetRandomLocation_WhenCalled_ReturnsAnGridCellFromGrid()
        {
            //Arrange
            ValueGenerator TestGenerator = new ValueGenerator();

            //Act

            //Assess
            Assert.AreEqual(expectedContents, actualContents, "GridCellTests - Contents - Contents incorrecly set");
        }*/
    }
}
