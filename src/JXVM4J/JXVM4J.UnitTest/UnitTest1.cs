using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JXVM4J.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 0x10;
            Assert.AreNotEqual(i, 0);
        }
    }
}
