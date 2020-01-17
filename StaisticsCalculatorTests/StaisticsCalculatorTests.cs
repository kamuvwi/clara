using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaisticsCalculator.Tests
{
    [TestClass()]
    public class StaisticsCalculatorTests
    {
        private readonly int[] arrayB = { 1, 2, 3, 4, 5 };
        [TestMethod()]
        public void MeanTest()
        {
            Assert.AreEqual(3, StatOperations.StatOperations.Mean(arrayB));
        }
    }
}