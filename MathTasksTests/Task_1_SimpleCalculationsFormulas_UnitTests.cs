using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Task_1_SimpleCalculationsFormulas;

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
        public void MathEquation01_Test(double act, double exp)
        {
            Assert.AreEqual(act, MathEquation1(exp));
        }

        [TestMethod()]
        public void MathEquation02_Test()
        {
            Assert.AreEqual(4.0865674509162612, MathEquation2(0.5));
        }

        [TestMethod()]
        public void MathEquation03_Test()
        {
            Assert.AreEqual(-0.693307715624919, MathEquation3(0.5));
        }

        [TestMethod()]
        public void MathEquation04_Test()
        {
            Assert.AreEqual(-0.1945226705589214, MathEquation4(0.5));
        }

        [TestMethod()]
        public void MathEquation05_Test()
        {
            Assert.AreEqual(1.9707031660809164, MathEquation5(0.5));
        }

        [TestMethod()]
        public void MathEquation06_Test()
        {
            Assert.AreEqual(-0.46245491699971997, MathEquation6(0.5));
        }

        [TestMethod()]
        public void MathEquation07_Test()
        {
            Assert.AreEqual(0.4252850278714168, MathEquation7(0.5));
        }

        [TestMethod()]
        public void MathEquation08_Test()
        {
            Assert.AreEqual(3.0155951223539015, MathEquation8(0.5));
        }

        [TestMethod()]
        public void MathEquation09_Test()
        {
            Assert.AreEqual(4.684800980826127, MathEquation9(0.5));
        }

        [TestMethod()]
        public void MathEquation10_Test()
        {
            Assert.AreEqual(1.68132452446846, MathEquation10(0.5));
        }

        [TestMethod()]
        public void MathEquation11_Test()
        {
            Assert.AreEqual(1.8301508389397878, MathEquation11(0.5));
        }        
        
        [TestMethod()]
        public void MathEquation12_Test()
        {
            Assert.AreEqual(0.2354643794722447, MathEquation12(0.5));
        }

        [TestMethod()]
        public void MathEquation13_Test()
        {
            Assert.AreEqual(0.8810007594483041, MathEquation13(0.5));
        }

        [TestMethod()]
        public void MathEquation14_Test()
        {
            Assert.AreEqual(5.287957648847091, MathEquation14(0.5));
        }

        [TestMethod()]
        public void MathEquation15_Test()
        {
            Assert.AreEqual(0.5421952384614525, MathEquation15(0.5));
        }

        [TestMethod()]
        public void MathEquation16_Test()
        {
            Assert.AreEqual(0.15937006338900464, MathEquation16(0.5));
        }

        [TestMethod()]
        public void MathEquation17_Test()
        {
            Assert.AreEqual(2.3664210758634745, MathEquation17(0.5));
        }

        [TestMethod()]
        public void MathEquation18_Test()
        {
            Assert.AreEqual(-0.22986470794798364, MathEquation18(0.5));
        }

        [TestMethod()]
        public void MathEquation19_Test()
        {
            Assert.AreEqual(1.1733604882584083, MathEquation19(0.5));
        }

        [TestMethod()]
        public void MathEquation20_Test()
        {
            Assert.AreEqual(2.3845301597029778, MathEquation20(0.5));
        }

        [TestMethod()]
        public void MathEquation21_Test()
        {
            Assert.AreEqual(0.7778934423141598, MathEquation21(0.5));
        }

        [TestMethod()]
        public void MathEquation22_Test()
        {
            Assert.AreEqual(1.5083222004978722, MathEquation22(0.5));
        }

        [TestMethod()]
        public void MathEquation23_Test()
        {
            Assert.AreEqual(0.4693153984446344, MathEquation23(0.5));
        }

        [TestMethod()]
        public void MathEquation24_Test()
        {
            Assert.AreEqual(0.4035823247003505, MathEquation24(0.5));
        }

        [TestMethod()]
        public void MathEquation25_Test()
        {
            Assert.AreEqual(5.86262110207455, MathEquation25(0.5));
        }

        [TestMethod()]
        public void MathEquation26_Test()
        {
            Assert.AreEqual(9.735463532485086, MathEquation26(0.5));
        }

        [TestMethod()]
        public void MathEquation27_Test()
        {
            Assert.AreEqual(1.6543518177132392, MathEquation27(0.5));
        }

        [TestMethod()]
        public void MathEquation28_Test()
        {
            Assert.AreEqual(1.8985132493584458, MathEquation28(0.5));
        }

        [TestMethod()]
        public void MathEquation29_Test()
        {
            Assert.AreEqual(0.9372666717887226, MathEquation29(0.5));
        }

        [TestMethod()]
        public void MathEquation30_Test()
        {
            Assert.AreEqual(0.738984891491119, MathEquation30(0.5));
        }
    }
}