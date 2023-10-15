using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class Task_1_UnitTests
    {
        [TestMethod()]
        public void MathEquation1Test_0_5()
        {
            Assert.AreEqual(2.4583251056855717, Program.MathEquation1(0.5));
        }

        [TestMethod()]
        public void MathEquation1Test_minus_1()
        {
            Assert.AreEqual(2.4583251056855717, Program.MathEquation1(-1));
        }

        [TestMethod()]
        public void MathEquation1Test_zero()
        {
            Assert.AreEqual(2.4583251056855717, Program.MathEquation1(0));
        }

        [TestMethod()]
        public void MathEquation1Test_1()
        {
            Assert.AreEqual(3.7531095076512795, Program.MathEquation1(1));
        }

        [TestMethod()]
        public void MathEquation1Test_10000()
        {
            Assert.AreEqual(2.4583251056855717, Program.MathEquation1(10000));
        }
    }
}