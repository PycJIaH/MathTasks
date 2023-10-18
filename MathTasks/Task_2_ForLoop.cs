using System;
using static System.Math;
using static MathTasks.Task_1_SimpleCalculationsFormulas;

namespace MathTasks
{
    public static class Task_2_ForLoop
    {
        static void Main(string[] args)
        {
            for (double i = 0.55; i < 1.05; i += 0.05)
            {
                Console.WriteLine("Iteration with number {0}, result is {1}", i, MathEquation1(i));
            }
        }
    }
}
