using System;
using static System.Math;

namespace MathTasks
{
    public class Task_2_ForLoop
    {
        static void Main(string[] args)
        {
            //double x = Task_1_SimpleCalculationsFormulas.ReadDoubleFromConsole();

            int N = ReadIntFromConsole();
            double A = Task_1_SimpleCalculationsFormulas.ReadDoubleFromConsole();
            double B = Task_1_SimpleCalculationsFormulas.ReadDoubleFromConsole();
            double increment = (B - A) / N;

            for (double i = 0; i <= N; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(MathEquation1(A));
                A += increment;
                Console.WriteLine(A);
            }

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
