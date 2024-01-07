using System;
using static System.Math;

namespace MathTasks
{
    public class Task_1_SimpleCalculationsFormulas
    {
        static void Main(string[] args)
        {
            double x = ReadDoubleFromConsole();

            Console.WriteLine(MathEquation1(x));
            Console.WriteLine(MathEquation2(x));
            Console.WriteLine(MathEquation3(x));
            Console.WriteLine(MathEquation4(x));
            Console.WriteLine(MathEquation5(x));
            Console.WriteLine(MathEquation6(x));
            Console.WriteLine(MathEquation7(x));
            Console.WriteLine(MathEquation8(x));
            Console.WriteLine(MathEquation9(x));
            Console.WriteLine(MathEquation10(x));
            Console.WriteLine(MathEquation11(x));
            Console.WriteLine(MathEquation12(x));
            Console.WriteLine(MathEquation13(x));
            Console.WriteLine(MathEquation14(x));
            Console.WriteLine(MathEquation15(x));
            Console.WriteLine(MathEquation16(x));
            Console.WriteLine(MathEquation17(x));
            Console.WriteLine(MathEquation18(x));
            Console.WriteLine(MathEquation19(x));
            Console.WriteLine(MathEquation20(x));
            Console.WriteLine(MathEquation21(x));
            Console.WriteLine(MathEquation22(x));
            Console.WriteLine(MathEquation23(x));
            Console.WriteLine(MathEquation24(x));
            Console.WriteLine(MathEquation25(x));
            Console.WriteLine(MathEquation26(x));
            Console.WriteLine(MathEquation27(x));
            Console.WriteLine(MathEquation28(x));
            Console.WriteLine(MathEquation29(x));
            Console.WriteLine(MathEquation30(x));
        }

        public static double ReadDoubleFromConsole()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the double value for equation: ");
                    double res = double.Parse(Console.ReadLine()!.Replace(".", ","));
                    Console.WriteLine("Input value: {0}", res);
                    return res;
                }
                catch
                {
                    // throw new Exception("You need to enter a valid double value! Repeat input!");
                    Console.WriteLine("You need to enter a valid double value! Repeat input!");
                }
            }
        }

        // Example number 1.
        public static double MathEquation1(double x)
        {
            double result = Sqrt(Pow(E, (2.2 * x))) - Abs(Sin((PI * x) / (x + 2.0 / 3))) + 1.7;

        return result;
    }

        // Example number 2.
        public static double MathEquation2(double x)
        {
            double result = Sqrt(Pow(Pow(x, 4), (1.0 / 5)) + Pow(Pow(x, 4 - x), (1.0 / 5))) + Log(Abs(x - 20.5));

        return result;
    }

        // Example number 3.
        public static double MathEquation3(double x)
        {
            double result = ((1.0 / 7.0) + Log(Sqrt(x))) * Pow(E, Sqrt(Abs(x - 2)));

        return result;
    }

        // Example number 4.
        public static double MathEquation4(double x)
        {
            double result = (Sqrt(x) * Sin(Pow(x, 2) / 2.0) - 1.3) / (Pow(x, (1.0 / 5)) + Pow(E, 3 * x) + Abs(Cos(x)));

        return result;
    }

        // Example number 5.
        public static double MathEquation5(double x)
        {
            double result = Sqrt(Pow(E, Abs(Sin(x)))) + (2 * Log(3 * x)) - (1.0 / 9);

        return result;
    }

        // Example number 6
        public static double MathEquation6(double x)
        {
            double result = (Sqrt(1 + Pow(x, 2)) + (Abs(Pow(Log(x), 3)) / (1.6 + Pow(x, 4)))) * Sin(7 * x);

        return result;
    }

        // Example number 7
        public static double MathEquation7(double x)
        {
            double result = Sqrt((1.0 / 5) + Pow(Pow(E, x), (1.0 / 5))) / Abs(Log(Pow(x, 2)) - 1.3);

        return result;
    }

        // Example number 8
        public static double MathEquation8(double x)
        {
            double result = 1.8 + Log(Abs((4.0 + (2.0 / 7)) - Tan(Sin((5 * x) / 3.0))));

        return result;
    }

        // Example number 9
        public static double MathEquation9(double x)
        {
            double result = (Abs(Sin(Sqrt(10.5 * x))) / (Pow(Pow(x, 2), (1.0 / 3)) - 0.143)) + 2 * PI * x;

        return result;
    }

        // Example number 10
        public static double MathEquation10(double x)
        {
            double result = (1.1 * Pow(E, x)) + Abs(Cos(Sqrt(PI * x))) - (4.0 / 9);

        return result;
    }

        // Example number 11
        public static double MathEquation11(double x)
        {
            double result = (Log(Sqrt(Abs(x - 2)) + 1.2) / (2 + Pow(E, x))) + Pow((2.0 / x), (1.0 / 3));

        return result;
    }

        // Example number 12
        public static double MathEquation12(double x)
        {
            double result = (1.0 / 3) * Sqrt(Abs(Sin(x))) * Pow(Pow(E, 0.12 * x), (1.0 / 3));

        return result;
    }

        // Example number 13
        public static double MathEquation13(double x)
        {
            double result = Pow(Pow(E, 2.0 / 3 - x), (1.0 / 5)) / Sqrt(Pow(x, 2) + Pow(x, 4) + Log(Abs(x - 3.4)));

        return result;
    }

        // Example number 14
        public static double MathEquation14(double x)
        {
            double result = (Sqrt(Pow(Sin(x / 2), 3)) + Pow(Pow(E, 1.3 * x) + Pow(E, -1.3 * x), (1.0 / 3))) / Abs(x - (7.0 / 9));

        return result;
    }

        // Example number 15
        public static double MathEquation15(double x)
        {
            double result = (Abs(x * Log(x) - (4.0 / 7)) * Sqrt(x)) / Pow(Pow(E, 4 * x - 1.1), (1.0 / 5));

        return result;
    }

        // Example number 16
        public static double MathEquation16(double x)
        {
            double result = Sqrt(Pow(E, 2 * x) * Sqrt(x) - ((x + (1.0 / 3)) / x)) * Abs(Cos(2.5 * x));

        return result;
    }

        // Example number 17
        public static double MathEquation17(double x)
        {
            double result = (Abs(7.2 - 10 * x) / Pow((x / 9) + Pow(E, 2 * x), (1.0 / 3))) * Atan((4 * Tan(2 * x)) / Sqrt(1.1 * Pow(x, 3)));

        return result;
    }

        // Example number 18
        public static double MathEquation18(double x)
        {
            double result = (Pow(x, 3) / Sqrt(3)) - Pow(E, x) * Log(Abs(Pow(1.37, 3) + Pow(x, 3))) + (4.0 / 3);

        return result;
    }

        // Example number 19
        public static double MathEquation19(double x)
        {
            double result = (Log(Sqrt(PI + Abs(2 - x))) / (3 - 1.0 / x)) + Pow(Pow(x, 2), (1.0 / 3)) * Sin(1.4 * x);

        return result;
    }

        // Example number 20
        public static double MathEquation20(double x)
        {
            double result = (Pow(Pow(Log(x), 2), (1.0 / 3)) + Tan(Cos(PI * x))) * Abs(Log(x / 10.5));

        return result;
    }

        // Example number 21
        public static double MathEquation21(double x)
        {
            double result = (Sin(0.5 * PI * x) + Pow(x, (1.0 / 5))) / (Sqrt(Abs(Cos(PI * x)) + 1) * Pow(E, Sqrt(x)));

        return result;
    }

        // Example number 22
        public static double MathEquation22(double x)
        {
            double result = (1.0 / Sqrt(x)) + Pow(Log(Abs(0.2 + Sin(x))), 2) * Pow(Pow(x, 2), (1.0 / 3));

        return result;
    }

        // Example number 23
        public static double MathEquation23(double x)
        {
            double result = (Log(Sqrt(Pow(E, 0.1 * x) + x)) / (x + Pow(10.7, (1.0 / 3)) + Atan(x))) + (2.0 / 5);

        return result;
    }

        // Example number 24
        public static double MathEquation24(double x)
        {
            double result = (1.0 / 3) * Pow(Pow(E, 6.3 + Sqrt(x)), (1.0 / 7)) * Abs((Cos((2 * x) / 3.0) - x));

        return result;
    }

        // Example number 25
        public static double MathEquation25(double x)
        {
            double result = (Abs(x - PI) * Pow(E, x / 3.0)) / Log(1.7 * Pow(x, (1.0 / 3)) + x * Sqrt(x));

        return result;
    }

        // Example number 26
        public static double MathEquation26(double x)
        {
            double result = 2 * Pow(E, Sqrt(Abs(Pow(x, 2) - Pow(1.71, 2)))) - Pow((x - PI) / (x + PI), 2);

        return result;
    }

        // Example number 27
        public static double MathEquation27(double x)
        {
            double result = (2 + (2.0 / 3) + Pow((x / 2.7), (1.0 / 3)) - Sqrt(Pow(E, -3 * x))) * Abs(Sin(5 * x));

        return result;
    }

        // Example number 28
        public static double MathEquation28(double x)
        {
            double result = ((Log(Pow(x, 2)) + PI) / Pow(E, 5 / 3)) - x * Atan(x / Sqrt(E)) + 1.4;

        return result;
    }

        // Example number 29
        public static double MathEquation29(double x)
        {
            double result = (Abs(Log(Pow(x, 2))) + (1.0 / 3)) / Sqrt(Pow(E, x / PI) + Pow(x, (1.0 / 3)) + 1.4);

        return result;
    }

        // Example number 30
        public static double MathEquation30(double x)
        {
            double result = Pow(Pow(PI, 2) - Pow(x, 2) + (1.0 / E), (1.0 / 3)) + Tan((x - 1) / x) + (1.0 / 7);

        return result;
    }
}