using System;

/// <summary>
/// Write a program that shows the sign (+ or -) of the product of 
/// three real numbers without calculating it. Use a sequence of if statements.
/// </summary>
class PlusOrMinusWithoutCalc
{
    static void Main()
    {
        Console.WriteLine("Please typer 3 numbers:");
        int[] numbers = new int[3];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool isPositive = true;
        foreach (var number in numbers)
        {
            if (number < 0)
            {
                isPositive = false;
            }
            else
            {
                isPositive = true;
            }
        }

        Console.WriteLine("The sum of {0}, {1} and {2} is positive? \n{3}", numbers[0], numbers[1], numbers[2], isPositive);
    }
}

