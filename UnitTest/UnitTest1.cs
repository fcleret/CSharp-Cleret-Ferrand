using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = Program.Addition(5, 6);
            Assert.AreEqual(11, result, 0, "L'addition ne s'effectue pas correctement");
        }
    }
}
