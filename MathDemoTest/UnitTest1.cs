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
            ////Program pgm = new Program();

            Assert.AreEqual(7, Program.SummationValue(6, 1));
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Program pgm = new Program();

            Assert.AreEqual(6, pgm.Multiply(6, 1));
        }

		[TestMethod]
        public void DivideTest()
        {
            Program pgm = new Program();

            Assert.AreEqual(6, pgm.Multiply(6, 1));
        }

    }
}
