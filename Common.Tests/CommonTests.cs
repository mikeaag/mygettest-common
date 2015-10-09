using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void TestWORLDReturnsWorld()
        {
            Assert.AreEqual("world", Common.WORLD);
        }
    }
}
