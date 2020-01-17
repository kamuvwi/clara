using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using StatOperations;

namespace StatOperationsTests
{
    [TestClass()]
    public class StatOperationsTests
    {
        private readonly int[] arrayB = { 1, 2, 3, 4, 5};
        [TestMethod()]
        public void MeanTest()
        {
            Assert.AreEqual(3, StatOperations.StatOperations.Mean(arrayB));
        }
    }
}
