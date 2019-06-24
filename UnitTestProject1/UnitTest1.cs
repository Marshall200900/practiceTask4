using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double e = 0.5;
            Assert.AreEqual(0.75, Program.FindRoot(e));
        }
        [TestMethod]
        public void TestMethod2()
        {
            double e = 100;
            Assert.AreEqual(0.5, Program.FindRoot(e));
        }
        [TestMethod]
        public void TestMethod3()
        {
            double e = 0.1;
            Assert.AreEqual(0.84375, Program.FindRoot(e));
        }
    }
}
