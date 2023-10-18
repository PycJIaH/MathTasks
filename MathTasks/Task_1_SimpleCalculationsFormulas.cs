using System;
using static System.Math;

public class Task_1_SimpleCalculationsFormulas
{
    static void Main(string[] args)
    {
        Console.Write("Enter the value of the variable: ");
        string? consoleInput = Console.ReadLine()!.Replace(".", ",");
        if (consoleInput is not null)
        {
            Console.WriteLine(MathEquation1(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation2(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation3(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation4(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation5(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation6(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation7(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation8(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation9(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation10(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation11(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation12(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation13(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation14(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation15(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation16(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation17(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation18(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation19(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation20(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation21(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation22(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation23(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation24(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation25(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation26(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation27(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation28(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation29(double.Parse(consoleInput)));
            Console.WriteLine(MathEquation30(double.Parse(consoleInput)));
        }
        else
        {
            Console.WriteLine("You need to enter a value");
        }

    }
    //Exmaple number 1.
    public static double MathEquation1(double x)
    {
        double result = Sqrt(Pow(E, (2.2 * x))) - Abs(Sin((PI * x) / (x + 2.0 / 3))) + 1.7;

        return result;
    }

    //Exmaple number 2.
    public static double MathEquation2(double x)
    {
        double result = Sqrt(Pow(Pow(x, 4), (1.0 / 5)) + Pow(Pow(x, 4 - x), (1.0 / 5))) + Log(Abs(x - 20.5));

        return result;
    }

    //Exmaple number 3.
    public static double MathEquation3(double x)
    {
        double result = ((1.0 / 7.0) + Log(Sqrt(x))) * Pow(E, Sqrt(Abs(x - 2)));

        return result;
    }

    //Exmaple number 4.
    public static double MathEquation4(double x)
    {
        double result = (Sqrt(x) * Sin(Pow(x, 2) / 2) - 1.3) / (Pow(Sqrt(x), 5) + Pow(E, 3 * x) + Abs(Cos(x)));

        return result;
    }

    //Exmaple number 5.
    public static double MathEquation5(double x)
    {
        double result = Sqrt(Pow(E, Abs(Pow(Sin(x), 3)))) + (2 * Log(3 * x)) - (1 / 9);

        return result;
    }

    //Exmaple number 6
    public static double MathEquation6(double x)
    {
        double result = (Sqrt(1 + Pow(x, 2)) + (Abs(Pow(Log(x), 3)) / (1.6 + Pow(x, 4)))) * Sin(7 * x);

        return result;
    }

    //Exmaple number 7
    public static double MathEquation7(double x)
    {
        double result = Sqrt((1 / 5) + Pow(Sqrt(Pow(E, x)), 5)) / Abs(Log(Pow(x, 2)) - 1.3);

        return result;
    }

    //Exmaple number 8
    public static double MathEquation8(double x)
    {
        double result = 1.8 + Log(Abs((4 * (2 / 7)) - Tan(Sin((5 * x) / 3))));

        return result;
    }

    //Exmaple number 9
    public static double MathEquation9(double x)
    {
        double result = Abs(Sin(Sqrt(10.5 * x))) / (Pow(Sqrt(Pow(x, 2)), 3) - 0.143);

        return result;
    }

    //Exmaple number 10
    public static double MathEquation10(double x)
    {
        double result = (1.1 * Pow(E, x)) + Abs(Cos(Sqrt(PI * x))) - (4 / 9);

        return result;
    }

    //Exmaple number 11
    public static double MathEquation11(double x)
    {
        double result = (Log(Sqrt(Abs(x - 2)) + 1.2) / (2 + Pow(E, x))) + Pow(Sqrt(2 / x), 3);

        return result;
    }

    //Exmaple number 12
    public static double MathEquation12(double x)
    {
        double result = Pow(Sqrt(Abs(Sin(x))), (1 / 3)) * Pow(Sqrt(Pow(E, 0.12 * x)), 3);

        return result;
    }

    //Exmaple number 13
    public static double MathEquation13(double x)
    {
        double result = Pow(Sqrt(Pow(E, 2 / 3 - x)), 5) / Sqrt(Pow(x, 2) + Pow(x, 4) + Log(Abs(x - 3.4)));

        return result;
    }

    //Exmaple number 14
    public static double MathEquation14(double x)
    {
        double result = (Sqrt(Pow(Sin(x / 2), 3)) + Pow(Sqrt(Pow(E, 1.3 * x) + Pow(E, -1 / 3 * x)), 3)) / Abs(x - (7 / 9));

        return result;
    }

    //Exmaple number 15
    public static double MathEquation15(double x)
    {
        double result = (Abs(x * Log(x) - (4 / 7)) * Sqrt(x)) / Pow(Sqrt(Pow(E, 4 * x - 1.1)), 5);

        return result;
    }

    //Exmaple number 16
    public static double MathEquation16(double x)
    {
        double result = Sqrt(Pow(E, 2 * x) * Sqrt(x) - ((x + (1 / 3)) / x)) * Abs(Cos(2.5 * x));

        return result;
    }

    //Exmaple number 17
    public static double MathEquation17(double x)
    {
        double result = (Abs(7.2 - 10 * x) / Pow(Sqrt((x / 9) + Pow(E, 2 * x)), 3)) * Atan((4 * Tan(2 * x)) / Sqrt(1.1 * Pow(x, 3)));

        return result;
    }

    //Exmaple number 18
    public static double MathEquation18(double x)
    {
        double result = (Pow(x, 3) / Sqrt(3)) - Pow(E, x) * Log(Abs(Pow(1.37, 3) + Pow(x, 3))) + (4 / 3);

        return result;
    }

    //Exmaple number 19
    public static double MathEquation19(double x)
    {
        double result = (Log(Sqrt(PI + Abs(2 - x))) / (3 - 1 / x)) + Pow(Sqrt(Pow(x, 2)), 3) * Sin(1.4 * x);

        return result;
    }

    //Exmaple number 20
    public static double MathEquation20(double x)
    {
        double result = (Pow(Sqrt(Pow(Log(x), 2)), 3) + Tan(Cos(PI * x))) * Abs(Log(x / 10.5));

        return result;
    }

    //Exmaple number 21
    public static double MathEquation21(double x)
    {
        double result = (Sin(0.5 * PI * x) + Pow(Sqrt(x), 5)) / (Sqrt(Abs(Cos(PI * x)) + 1) * Pow(E, Sqrt(x)));

        return result;
    }

    //Exmaple number 22
    public static double MathEquation22(double x)
    {
        double result = (1 / Sqrt(x)) + Pow(Log(Abs(0.2 + Sin(x))), 2) * Pow(Sqrt(Pow(x, 2)), 3);
        //double result = (1 / Sqrt(x)) + Pow(Log(Abs(0.2 + Sin(x)) * Pow(Sqrt(Pow(x, 2)), 3)), 2); - Возможен и такой вариант но вряд-ли

        return result;
    }

    //Exmaple number 23
    public static double MathEquation23(double x)
    {
        double result = (Log(Sqrt(Pow(E, 0.1 * x))) / (x + Pow(Sqrt(10.7), 3) + Atan(x))) + (2 / 5);

        return result;
    }

    //Exmaple number 24
    public static double MathEquation24(double x)
    {
        double result = (1 / 3) * Pow(Sqrt(Pow(E, 6.3 + Sqrt(x))), 7) * Abs((Cos(2 * x) / 3) - x);

        return result;
    }

    //Exmaple number 25
    public static double MathEquation25(double x)
    {
        double result = (Abs(x - PI) * Pow(E, x / 3)) / Log(1.7 * Pow(Sqrt(x), 3) + x * Sqrt(x));

        return result;
    }

    //Exmaple number 26
    public static double MathEquation26(double x)
    {
        double result = 2 * Pow(E, Sqrt(Abs(Pow(x, 2) - Pow(1.71, 2)))) - Pow((x - PI) / (x + PI), 2);

        return result;
    }

    //Exmaple number 27
    public static double MathEquation27(double x)
    {
        double result = (2 * (2 / 3) + Pow(Sqrt(x / 2.7), 3) - Sqrt(Pow(E, -3 * x))) * Abs(Sin(5 * x));

        return result;
    }

    //Exmaple number 28
    public static double MathEquation28(double x)
    {
        double result = ((Log(Pow(x, 2)) + PI) / Pow(E, 5 / 3)) - x * Atan(x / Sqrt(E)) + 1.4;

        return result;
    }

    //Exmaple number 29
    public static double MathEquation29(double x)
    {
        double result = (Abs(Log(Pow(x, 2))) + (1 / 3)) / Sqrt(Pow(E, x / PI) + Pow(Sqrt(x), 3) + 1.4);

        return result;
    }

    //Exmaple number 30
    public static double MathEquation30(double x)
    {
        double result = Pow(Sqrt(Pow(PI, 2) - Pow(x, 2) + (1 / E)), 3) + Tan((x - 1) / x) + (1 / 7);

        return result;
    }
}