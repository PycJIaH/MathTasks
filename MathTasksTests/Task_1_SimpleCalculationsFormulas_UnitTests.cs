using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTasksTests
{
    [TestClass()]
    public class Task_1_SimpleCalculationsFormulas_UnitTests
    {
        [TestMethod()]
        [DataRow(2.4583251056855717, 0.5)]
        [DataRow(2.0328710836980775, -1)]
        [DataRow(2.7, 0)]
        [DataRow(3.7531095076512795, 1)]
        [DataRow(59875.64662487577, 10)]
        public void MathEquation1_Tests(double act, double exp)
        {
            Assert.AreEqual(act, Task_1_SimpleCalculationsFormulas.MathEquation1(exp));
        }

        [TestMethod()]
        public void MathEquation2_Tests()
        {
            Assert.AreEqual(4.0865674509162612, Task_1_SimpleCalculationsFormulas.MathEquation2(0.5));
        }

        [TestMethod()]
        public void MathEquation3_Tests()
        {
            Assert.AreEqual(-0.693307715624919, Task_1_SimpleCalculationsFormulas.MathEquation3(0.5));
        }
    }
}