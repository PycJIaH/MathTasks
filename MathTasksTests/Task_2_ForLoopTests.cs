using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static MathTasks.Task_2_ForLoop;

namespace MathTasks.Task_2_ForLoop_UnitTests
{
    [TestClass()]
    public class Task_2_ForLoopTests
    {
        [TestMethod()]
        public void Task2Solution_Test()
        {
            Assert.AreEqual(3.916283860875562, Task2Solution(10, 0.55, 1.0));
        }
    }
}