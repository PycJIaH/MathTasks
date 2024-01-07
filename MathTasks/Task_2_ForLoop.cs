using System;
using static System.Math;
using static MathTasks.Task_1_SimpleCalculationsFormulas;

namespace MathTasks
{
    public class Task_2_ForLoop
    {
        static void Main(string[] args)
        {
            Task2Solution(ReadIntFromConsole(), ReadDoubleFromConsole(), ReadDoubleFromConsole());            
        }

        // Solution for issue No.2
        public static double Task2Solution(int N, double A, double B)
        {
            double increment = (B - A) / N;
            double result = 0;

            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine(i);
                result = MathEquation1(A);
                Console.WriteLine(result);
                A += increment;
                Console.WriteLine(A);
            }

            return result;
        }

        public static int ReadIntFromConsole()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the integer value for equation: ");
                    int res = int.Parse(Console.ReadLine()!.Replace(".", ","));
                    Console.WriteLine("Input value: {0}", res);
                    return res;
                }
                catch
                {
                    // throw new Exception("You need to enter a valid integer value! Repeat input!");
                    Console.WriteLine("You need to enter a valid integer value! Repeat input!");
                }
            }
        }
    }
}
