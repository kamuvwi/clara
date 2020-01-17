using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace StatOperations.Tests
{
    [TestClass()]
    public class VarianceTests
    {
        private readonly double[] arrayA = { 6, 2, 3, 1 };
        //private readonly double[] subarray = { -2, -1, 0, 1, 2 };
        //private readonly int a = 4;
       // private readonly ArrayList subarrayB = new ArrayList();

        private readonly int mean = 3;
        [TestMethod()]
        public void VariancesTest()
        {
            
            Assert.AreEqual(3.5, Variance.Variances(arrayA, mean));
        }

        
    }
}