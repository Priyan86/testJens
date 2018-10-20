using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicalDemo;

namespace MathDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program pgm = new Program();

            Assert.AreEqual(7, pgm.SummationValue(6, 1));
        }
    }
}
