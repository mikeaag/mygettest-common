using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlanBlunden.Common;

namespace AlanBlunden.Common.Tests
{
    [TestClass]
    public class CommonTests
    {
        [TestMethod]
        public void TestHELLOReturnsHello()
        {
            Assert.AreEqual("hello", Common.HELLO);
        }
    }
}
