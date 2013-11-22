using System;
using System.Linq;

/// <summary>
/// Sort 3 real values in descending order using nested if statements.
/// </summary>
class SortInDescending
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number: ");
        double c = double.Parse(Console.ReadLine());
        double[] numbers = { a, b, c };

        var ordered = from n in numbers // using nested if statements, no I don't think so
                      orderby n descending
                      select n;
        foreach (var item in ordered)
        {
            Console.WriteLine(item);
        }
    }
}

