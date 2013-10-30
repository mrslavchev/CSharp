using System;

/// <summary>
/// Write a program that reads two positive integer numbers and prints how many
/// numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). 
/// Example: p(17,25) = 2.
/// </summary>
class HowManyPExist
{
    static void Main()
    {
        Console.WriteLine("Please type first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("PLese type second number:");
        int num2 = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = num1; i <= num2; i++)
        {
            if ((i % 5) == 0)
            {
                count++;
            }
        }

        Console.WriteLine("{0} numbers exist", count);
    }
}


