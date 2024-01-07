using System;
using static System.Math;

namespace MathTasks
{
    public class Task_2_ForLoop
    {
        static void Main(string[] args)
        {
            Task2Solution(ReadIntFromConsole(), Task_1_SimpleCalculationsFormulas.ReadDoubleFromConsole(),
                Task_1_SimpleCalculationsFormulas.ReadDoubleFromConsole());            
        }

        // Solution for issue No.2
        public static double Task2Solution(int N, double A, double B)
        {
            double increment = (B - A) / N;

            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(MathEquation1(A));
                A += increment;
                Console.WriteLine(A);
            }

            return MathEquation1(A);
        }

        // Example number 1.
        public static double MathEquation1(double x)
        {
            double result = Sqrt (Pow(E, (2.2 * x))) - Abs(Sin((PI * x) / (x + 2.0 / 3))) + 1.7;

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
                    // throw new Exception("You need to enter a valid double value! Repeat input!");
                    Console.WriteLine("You need to enter a valid integer value! Repeat input!");
                }
            }
        }
    }


}
