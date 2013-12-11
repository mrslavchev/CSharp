using System;

/// <summary>
/// Write a program that shows the sign (+ or -) of the product of 
/// three real numbers without calculating it. Use a sequence of if statements.
/// </summary>
class PlusOrMinusWithoutCalc
{
    static void Main()
    {
        Console.WriteLine("Please type 3 numbers:");
        int[] numbers = new int[3];
        int minusCounter = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            if (numbers[i] < 0)
            {
                minusCounter++;
            }
        }
        bool isEven = (minusCounter & 1) == 0;
        Console.WriteLine("Whats the sign of the product of {0}, {1} and {2} ?", numbers[0], numbers[1], numbers[2]);
        Console.WriteLine(isEven? "+" : "-");

        Console.WriteLine("Check WITH calculating: The product is: {0}", numbers[0] * numbers[1] * numbers[2]);  
    }
}

