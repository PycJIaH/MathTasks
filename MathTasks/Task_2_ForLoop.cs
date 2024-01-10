using System;
using static System.Math;
using static MathTasks.Task_1_SimpleCalculationsFormulas;

namespace MathTasks
{
    public class Task_2_ForLoop
    {
        static void Main(string[] args)
        {
            Dictionary<double, double> res = Task2Solution(ReadDoubleFromConsole(), ReadDoubleFromConsole(), ReadUIntFromConsole());

            foreach (var item in res)
            {
                Console.WriteLine("For x = {0:N4}, f(x) = {1:N4}", item.Key, item.Value);
            }
        }

        // Составить алгоритм и программу вычисления таблицы значений функции f(x)
        // из задачи #1 для N значений аргумента X, равномерно распределенных на отрезке [A, B].
        // Для проверки программы задать N = 10; A = 0,55; B = 1.
        public static Dictionary<double, double> Task2Solution(double A, double B, uint N)
        {
            double increment = (B - A) / N;
            Dictionary<double, double> result = new();

            for (double x = A; x <= B; x += increment)
            {
                result[x] = MathEquation1(x);
            }

            return result;
        }

        public static uint ReadUIntFromConsole()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the integer value for equation: ");
                    uint res = uint.Parse(Console.ReadLine()!.Replace(".", ","));
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
