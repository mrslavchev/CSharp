using System;
using System.Numerics;

/// <summary>
/// Write a program that, for a given two integer numbers N and X, calculates the sum
/// S = 1 + 1!/X + 2!/X2 + … + N!/XN
/// </summary>
class FactorielSumExpression
{
    static void Main()
    {
        Console.WriteLine("Calculate sum S = 1 + 1!/X + 2!/X^2 + … + N!/X^N.\n");
        Console.Write("Enter number N = ");
        BigInteger n;
        bool checkN = BigInteger.TryParse(Console.ReadLine(), out n);
        bool isNPositive = n > 0;

        while (checkN == false || isNPositive == false)
        {
            if (checkN == false)
            {
                Console.WriteLine("Incorrect input! \nYou didn't enter a number! ");
                Console.Write("Please enter corectlly N = ");
                checkN = BigInteger.TryParse(Console.ReadLine(), out n);
            }
            else
            {
                Console.WriteLine("Incorrect input! \nYou must enter number N > 0! ");
                Console.Write("Please enter corectlly N = ");
                checkN = BigInteger.TryParse(Console.ReadLine(), out n);
            }

            isNPositive = n > 0;
        }

        Console.Write("Enter number X = ");
        BigInteger x;
        bool checkX = BigInteger.TryParse(Console.ReadLine(), out x);
        bool isKPositive = x > 0;

        while (checkX == false || isKPositive == false)
        {
            if (checkX == false)
            {
                Console.WriteLine("Incorrect input! \nYou didn't enter a number! ");
                Console.Write("Please enter corectlly X = ");
                checkX = BigInteger.TryParse(Console.ReadLine(), out x);
            }
            else
            {
                Console.WriteLine("Incorrect input! \nYou must enter number X > 0!");
                Console.Write("Please enter corectlly X = ");
                checkX = BigInteger.TryParse(Console.ReadLine(), out x);
            }
            isKPositive = x > 0;
        }

        double sum = 1;
        BigInteger currentFactoriel = 1;
        BigInteger power = 1;
        for (BigInteger i = 1; i <= n; i++)
        {
            currentFactoriel = currentFactoriel * i;
            power = power * x;
            sum = sum + (double)currentFactoriel / (double)power;
        }

        Console.WriteLine("sum S = 1 + 1!/X + 2!/X^2 + … + N!/X^N = {0}", sum);
    }
}
