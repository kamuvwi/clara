using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations.Tests
{
    [TestClass()]
    public class ModeTests
    {
        private readonly dynamic[] arrayA = { 6, 2, 3, 1, 2};
        [TestMethod()]
        public void ModTest()
        {
            Assert.AreEqual(2, Mode.Mod(arrayA));
        }
    }
}