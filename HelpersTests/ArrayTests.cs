using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers.Tests
{
    [TestClass()]

    
    public class ArrayTests
    {
        private readonly int[] arrayA = { 1, 2, 3, 4, 5};
        [TestMethod()]
        public void ArrayLengthTest()
        {
            Assert.AreEqual(5, Helpers.Array.ArrayLength(arrayA));
        }
    }
}