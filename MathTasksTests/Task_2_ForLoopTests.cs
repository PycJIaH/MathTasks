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
            Dictionary<double, double> expectedDict = new()
            {
                { 0.55, 2.542574618653433 },
                { 0.5950000000000001, 2.6281582048839494 },
                { 0.6400000000000001, 2.722337633622857 },
                { 0.6850000000000002, 2.824649451993068 },
                { 0.7300000000000002, 2.9347633195293596 },
                { 0.7750000000000002, 3.0524615354256195 },
                { 0.8200000000000003, 3.177622241974861 },
                { 0.8650000000000003, 3.310205731348277 },
                { 0.9100000000000004, 3.4502433411247706 },
                { 0.9550000000000004, 3.597828494118035 }
            };
            Dictionary<double, double> actualDict = Task2Solution(0.55, 1.0, 10);
            expectedDict.Select(i => $"X = {i.Key}: Equality expected = {i.Value}").ToList().ForEach(Console.WriteLine);
            Console.WriteLine("\n");
            actualDict.Select(i => $"X = {i.Key}: Equality actual= {i.Value}").ToList().ForEach(Console.WriteLine);

            Assert.IsTrue(expectedDict.SequenceEqual(actualDict));
        }
    }
}