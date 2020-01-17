using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StandardDeviationTests
    {
        private readonly double[] arrayA = { 6, 2, 3, 1 };
        [TestMethod()]
        public void StandardDevTest()
        {
            Assert.AreEqual(1.87, StandardDeviation.StandardDev(arrayA));
        }
    }
}