using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace day2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddingNumberAndStopReturnsResult()
        {
            int[] input = { 1, 0, 0, 0, 99 };
            var intcode = new Intcode(input);

            Assert.AreEqual(2, intcode.process());
        }
        [TestMethod]
        public void TestMultiplyNumberAndStopReturnsResult()
        {
            int[] input = { 2, 0, 0, 0, 99 };
            var intcode = new Intcode(input);

            Assert.AreEqual(4, intcode.process());
        }
        [TestMethod]
        public void TestHandlesMultipleOperations()
        {
            int[] input = { 1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50 };
            var intcode = new Intcode(input);

            Assert.AreEqual(3500, intcode.process());
        }
    }
}
