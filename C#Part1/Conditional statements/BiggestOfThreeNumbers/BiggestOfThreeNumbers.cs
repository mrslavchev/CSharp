using System;

/// <summary>
/// Write a program that finds the biggest of three integers using nested if statements.
/// </summary>
class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number: ");
        double c = double.Parse(Console.ReadLine());
        if ((a <= b) && (a <= c))
        {
            if (b > c)
            {
                Console.WriteLine("The biggeest of all is {0}", b);
            }
            else
            {
                Console.WriteLine("The biggeest of all is {0}", c);
            }
        }
        else
        {
            Console.WriteLine("The biggeest of all is {0}", a);
        }
    }
}