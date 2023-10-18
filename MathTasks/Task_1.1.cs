using System;
using static System.Math;

public class Program
{
    static void Main(string[] args)
    {      
        Console.Write("Enter the value of the variable: ");
        string? consoleInput = Console.ReadLine()!.Replace(".", ",");
        if (consoleInput is not null)
        {
            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("Пример #{0}", i + 1);
                Console.WriteLine(MathEquationAll(double.Parse(consoleInput), i));
            }            
        }
        else
        {
            Console.WriteLine("You need to enter a value");
        }        
        
    }

    //Пример номер 2.
    public static double MathEquationAll(double value, int exampleNumber)
    {
        double x = value;

        List<double> mathFormulas = new List<double>();

        mathFormulas.Add(Sqrt(Pow(E, 2.2 * x)) - Abs(Sin((PI * x) / (x + (2 / 3)))) + 1.7);
        mathFormulas.Add(Sqrt(Pow(Sqrt(Pow(x, 4)), 5) + Pow(Sqrt(Pow(x, 4 - x)), 5)) + Log(Abs(x - 20.5)));
        mathFormulas.Add(((1 / 7) + Log(Sqrt(x))) * Pow(E, Sqrt(x - 2)));
        mathFormulas.Add((Sqrt(x) * Sin(Pow(x, 2) / 2) - 1.3) / (Pow(Sqrt(x), 5) + Pow(E, 3 * x) + Abs(Cos(x))));
        mathFormulas.Add(Sqrt(Pow(E, Abs(Pow(Sin(x), 3)))) + (2 * Log(3 * x)) - (1 / 9));
        mathFormulas.Add((Sqrt(1 + Pow(x, 2)) + (Abs(Pow(Log(x), 3)) / (1.6 + Pow(x, 4)))) * Sin(7 * x));
        mathFormulas.Add(Sqrt((1 / 5) + Pow(Sqrt(Pow(E, x)), 5)) / Abs(Log(Pow(x, 2)) - 1.3));
        mathFormulas.Add(1.8 + Log(Abs((4 * (2 / 7)) - Tan(Sin((5 * x) / 3)))));
        mathFormulas.Add(Abs(Sin(Sqrt(10.5 * x))) / (Pow(Sqrt(Pow(x, 2)), 3) - 0.143));
        mathFormulas.Add((1.1 * Pow(E, x)) + Abs(Cos(Sqrt(PI * x))) - (4 / 9));
        mathFormulas.Add((Log(Sqrt(Abs(x - 2)) + 1.2) / (2 + Pow(E, x))) + Pow(Sqrt(2 / x), 3));
        mathFormulas.Add(Pow(Sqrt(Abs(Sin(x))), (1 / 3)) * Pow(Sqrt(Pow(E, 0.12 * x)), 3));
        mathFormulas.Add(Pow(Sqrt(Pow(E, 2 / 3 - x)), 5) / Sqrt(Pow(x, 2) + Pow(x, 4) + Log(Abs(x - 3.4))));
        mathFormulas.Add((Sqrt(Pow(Sin(x / 2), 3)) + Pow(Sqrt(Pow(E, 1.3 * x) + Pow(E, -1 / 3 * x)), 3)) / Abs(x - (7 / 9)));
        mathFormulas.Add((Abs(x * Log(x) - (4 / 7)) * Sqrt(x)) / Pow(Sqrt(Pow(E, 4 * x - 1.1)), 5));
        mathFormulas.Add(Sqrt(Pow(E, 2 * x) * Sqrt(x) - ((x + (1 / 3)) / x)) * Abs(Cos(2.5 * x)));
        mathFormulas.Add((Abs(7.2 - 10 * x) / Pow(Sqrt((x / 9) + Pow(E, 2 * x)), 3)) * Atan((4 * Tan(2 * x)) / Sqrt(1.1 * Pow(x, 3))));
        mathFormulas.Add((Pow(x, 3) / Sqrt(3)) - Pow(E, x) * Log(Abs(Pow(1.37, 3) + Pow(x, 3))) + (4 / 3));
        mathFormulas.Add((Log(Sqrt(PI + Abs(2 - x))) / (3 - 1 / x)) + Pow(Sqrt(Pow(x, 2)), 3) * Sin(1.4 * x));
        mathFormulas.Add((Pow(Sqrt(Pow(Log(x), 2)), 3) + Tan(Cos(PI * x))) * Abs(Log(x / 10.5)));
        mathFormulas.Add((Sin(0.5 * PI * x) + Pow(Sqrt(x), 5)) / (Sqrt(Abs(Cos(PI * x)) + 1) * Pow(E, Sqrt(x))));
        mathFormulas.Add((1 / Sqrt(x)) + Pow(Log(Abs(0.2 + Sin(x))), 2) * Pow(Sqrt(Pow(x, 2)), 3));
        mathFormulas.Add((Log(Sqrt(Pow(E, 0.1 * x))) / (x + Pow(Sqrt(10.7), 3) + Atan(x))) + (2 / 5));
        mathFormulas.Add((1 / 3) * Pow(Sqrt(Pow(E, 6.3 + Sqrt(x))), 7) * Abs((Cos(2 * x) / 3.0) - x));
        mathFormulas.Add((Abs(x - PI) * Pow(E, x / 3)) / Log(1.7 * Pow(Sqrt(x), 3) + x * Sqrt(x)));
        mathFormulas.Add(2 * Pow(E, Sqrt(Abs(Pow(x, 2) - Pow(1.71, 2)))) - Pow((x - PI) / (x + PI), 2));
        mathFormulas.Add((2 * (2 / 3) + Pow(Sqrt(x / 2.7), 3) - Sqrt(Pow(E, -3 * x))) * Abs(Sin(5 * x)));
        mathFormulas.Add(((Log(Pow(x, 2)) + PI) / Pow(E, 5 / 3)) - x * Atan(x / Sqrt(E)) + 1.4);
        mathFormulas.Add((Abs(Log(Pow(x, 2))) + (1 / 3)) / Sqrt(Pow(E, x / PI) + Pow(Sqrt(x), 3) + 1.4));
        mathFormulas.Add(Pow(Sqrt(Pow(PI, 2) - Pow(x, 2) + (1 / E)), 3) + Tan((x - 1) / x) + (1 / 7));


        double result = mathFormulas[exampleNumber];

        return result;
    }


    //Пример номер 1.
    public static double MathEquation1(double x)
    {
        double result = Sqrt(Pow(E, (2.2 * x))) - Abs(Sin((PI * x) / (x + 2.0 / 3))) + 1.7;

        return result;
    }

    //Пример номер 2.
    public static double MathEquation2(double value)
    {
        double x = value;

        double result = Sqrt(Pow(Sqrt(Pow(x, 4)), 5) + Pow(Sqrt(Pow(x, 4 - x)), 5)) + Log(Abs(x - 20.5));

        return result;
    }

    //Пример номер 3.
    public static double MathEquation3(double value)
    {
        double x = value;

        double result = ((1 / 7) + Log(Sqrt(x))) * Pow(E, Sqrt(x - 2));

        return result;
    }

    //Пример номер 4.
    public static double MathEquation4(double value)
    {
        double x = value;

        double result = (Sqrt(x) * Sin(Pow(x, 2) / 2) - 1.3) / (Pow(Sqrt(x), 5) + Pow(E, 3 * x) + Abs(Cos(x)));

        return result;
    }

    //Пример номер 5.
    public static double MathEquation5(double value)
    {
        double x = value;

        double result = Sqrt(Pow(E, Abs(Pow(Sin(x), 3)))) + (2 * Log(3 * x)) - (1 / 9);

        return result;
    }

    //Пример номер 6
    public static double MathEquation6(double value)
    {
        double x = value;

        double result = (Sqrt(1 + Pow(x, 2)) + (Abs(Pow(Log(x), 3)) / (1.6 + Pow(x, 4)))) * Sin(7 * x);

        return result;
    }

    //Пример номер 7
    public static double MathEquation7(double value)
    {
        double x = value;

        double result = Sqrt((1 / 5) + Pow(Sqrt(Pow(E, x)), 5)) / Abs(Log(Pow(x, 2)) - 1.3);

        return result;
    }

    //Пример номер 8
    public static double MathEquation8(double value)
    {
        double x = value;

        double result = 1.8 + Log(Abs((4 * (2 / 7)) - Tan(Sin((5 * x) / 3))));

        return result;
    }

    //Пример номер 9
    public static double MathEquation9(double value)
    {
        double x = value;

        double result = Abs(Sin(Sqrt(10.5 * x))) / (Pow(Sqrt(Pow(x, 2)), 3) - 0.143);

        return result;
    }

    //Пример номер 10
    public static double MathEquation10(double value)
    {
        double x = value;

        double result = (1.1 * Pow(E, x)) + Abs(Cos(Sqrt(PI * x))) - (4 / 9);

        return result;
    }

    //Пример номер 11
    public static double MathEquation11(double value)
    {
        double x = value;

        double result = (Log(Sqrt(Abs(x - 2)) + 1.2) / (2 + Pow(E, x))) + Pow(Sqrt(2 / x), 3);

        return result;
    }

    //Пример номер 12
    public static double MathEquation12(double value)
    {
        double x = value;

        double result = Pow(Sqrt(Abs(Sin(x))), (1 / 3)) * Pow(Sqrt(Pow(E, 0.12 * x)), 3);

        return result;
    }

    //Пример номер 13
    public static double MathEquation13(double value)
    {
        double x = value;

        double result = Pow(Sqrt(Pow(E, 2 / 3 - x)), 5) / Sqrt(Pow(x, 2) + Pow(x, 4) + Log(Abs(x - 3.4)));

        return result;
    }

    //Пример номер 14
    public static double MathEquation14(double value)
    {
        double x = value;

        double result = (Sqrt(Pow(Sin(x / 2), 3)) + Pow(Sqrt(Pow(E, 1.3 * x) + Pow(E, -1 / 3 * x)), 3)) / Abs(x - (7 / 9));

        return result;
    }

    //Пример номер 15
    public static double MathEquation15(double value)
    {
        double x = value;

        double result = (Abs(x * Log(x) - (4 / 7)) * Sqrt(x)) / Pow(Sqrt(Pow(E, 4 * x - 1.1)), 5);

        return result;
    }

    //Пример номер 16
    public static double MathEquation16(double value)
    {
        double x = value;

        double result = Sqrt(Pow(E, 2 * x) * Sqrt(x) - ((x + (1 / 3)) / x)) * Abs(Cos(2.5 * x));

        return result;
    }

    //Пример номер 17
    public static double MathEquation17(double value)
    {
        double x = value;

        double result = (Abs(7.2 - 10 * x) / Pow(Sqrt((x / 9) + Pow(E, 2 * x)), 3)) * Atan((4 * Tan(2 * x)) / Sqrt(1.1 * Pow(x, 3)));

        return result;
    }

    //Пример номер 18
    public static double MathEquation18(double value)
    {
        double x = value;

        double result = (Pow(x, 3) / Sqrt(3)) - Pow(E, x) * Log(Abs(Pow(1.37, 3) + Pow(x, 3))) + (4 / 3);

        return result;
    }

    //Пример номер 19
    public static double MathEquation19(double value)
    {
        double x = value;

        double result = (Log(Sqrt(PI + Abs(2 - x))) / (3 - 1 / x)) + Pow(Sqrt(Pow(x, 2)), 3) * Sin(1.4 * x);

        return result;
    }

    //Пример номер 20
    public static double MathEquation20(double value)
    {
        double x = value;

        double result = (Pow(Sqrt(Pow(Log(x), 2)), 3) + Tan(Cos(PI * x))) * Abs(Log(x / 10.5));

        return result;
    }

    //Пример номер 21
    public static double MathEquation21(double value)
    {
        double x = value;

        double result = (Sin(0.5 * PI * x) + Pow(Sqrt(x), 5)) / (Sqrt(Abs(Cos(PI * x)) + 1) * Pow(E, Sqrt(x)));

        return result;
    }

    //Пример номер 22
    public static double MathEquation22(double value)
    {
        double x = value;

        double result = (1 / Sqrt(x)) + Pow(Log(Abs(0.2 + Sin(x))), 2) * Pow(Sqrt(Pow(x, 2)), 3);
        //double result = (1 / Sqrt(x)) + Pow(Log(Abs(0.2 + Sin(x)) * Pow(Sqrt(Pow(x, 2)), 3)), 2); - Возможен и такой вариант но вряд-ли

        return result;
    }

    //Пример номер 23
    public static double MathEquation23(double value)
    {
        double x = value;

        double result = (Log(Sqrt(Pow(E, 0.1 * x))) / (x + Pow(Sqrt(10.7), 3) + Atan(x))) + (2 / 5);

        return result;
    }

    //Пример номер 24
    public static double MathEquation24(double value)
    {
        double x = value;

        double result = (1 / 3) * Pow(Sqrt(Pow(E, 6.3 + Sqrt(x))), 7) * Abs((Cos(2 * x) / 3) - x);

        return result;
    }

    //Пример номер 25
    public static double MathEquation25(double value)
    {
        double x = value;

        double result = (Abs(x - PI) * Pow(E, x / 3)) / Log(1.7 * Pow(Sqrt(x), 3) + x * Sqrt(x));

        return result;
    }

    //Пример номер 26
    public static double MathEquation26(double value)
    {
        double x = value;

        double result = 2 * Pow(E, Sqrt(Abs(Pow(x, 2) - Pow(1.71, 2)))) - Pow((x - PI) / (x + PI), 2);

        return result;
    }

    //Пример номер 27
    public static double MathEquation27(double value)
    {
        double x = value;

        double result = (2 * (2 / 3) + Pow(Sqrt(x / 2.7), 3) - Sqrt(Pow(E, -3 * x))) * Abs(Sin(5 * x));

        return result;
    }

    //Пример номер 28
    public static double MathEquation28(double value)
    {
        double x = value;

        double result = ((Log(Pow(x, 2)) + PI) / Pow(E, 5 / 3)) - x * Atan(x / Sqrt(E)) + 1.4;

        return result;
    }

    //Пример номер 29
    public static double MathEquation29(double value)
    {
        double x = value;

        double result = (Abs(Log(Pow(x, 2))) + (1 / 3)) / Sqrt(Pow(E, x / PI) + Pow(Sqrt(x), 3) + 1.4);

        return result;
    }

    //Пример номер 30
    public static double MathEquation30(double value)
    {
        double x = value;

        double result = Pow(Sqrt(Pow(PI, 2) - Pow(x, 2) + (1 / E)), 3) + Tan((x - 1) / x) + (1 / 7);

        return result;
    }
}
