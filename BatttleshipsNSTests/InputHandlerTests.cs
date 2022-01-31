﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleshipsNS;

namespace BatttleshipsNSTests
{
    public class FakeUserInput : IUserInput
    {
        public string GetUserInput()
        { return "A1"; }
    }

    [TestClass]
    public class InputHandlerTests
    {
        [TestMethod]
        public void GetTargetSpace_WhenInputHandlerCreatedWithSingleIntger_WithNoArguments_ReturnsTargetSpace()
        {
            int[] expected = {0, 0, 0, 0, 0};
            int TestSize = 1;

            

            string actual = TestSpace.ID;

            Assert.AreEqual(expected, actual, true, ($@"BoardSpaceTests_ID : Incorrect ID returned"));
        }
    }
}
