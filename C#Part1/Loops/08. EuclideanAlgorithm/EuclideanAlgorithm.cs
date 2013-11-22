using System;

/// <summary>
/// Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
/// Use the Euclidean algorithm (find it in Internet).
/// </summary>
class EuclideanAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another number: ");
        int num2 = int.Parse(Console.ReadLine());
        if (!((num1 == 0) || (num2 == 0)))
        {
            while ((num1 != 0) && (num2 != 0))
            {
                if (num1 > num2)
                {
                    num1 %= num2;
                }
                else
                {
                    num2 %= num1;
                }
            }
            if (num1 == 0)
            {
                Console.WriteLine("The GCD of the two numbers is {0}", num2);
            }
            else
            {
                Console.WriteLine("GCD is {0}", num1);
            }
        }
        else
        {
            Console.WriteLine("One or both divisors are 0");
        }
    }
}

