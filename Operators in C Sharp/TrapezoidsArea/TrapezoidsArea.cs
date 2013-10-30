using System;

/// <summary>
/// Write an expression that calculates trapezoid's area by given sides a and b and height h.
/// </summary>
class TrapezoidsArea
{
    static void Main()
    {
        double a = 5;
        double b =6;
        double h = 10;
        double area = (((a + b) / 2) * h);
        Console.WriteLine("If trapezoid's one leg={0}, leg2={1} and height={2}, than its area is:{3}",a,b,h,area);
    }
}

