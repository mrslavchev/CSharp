using System;

/// <summary>
/// Write a program that calculates N!/K! for given N and K (1<K<N).
/// </summary>
class KDividesNFactorial
{
    static void Main()
    {
        Console.WriteLine("Please enter value for N: ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for K: ");
        decimal k = decimal.Parse(Console.ReadLine());
        decimal factorialN = 1;
        decimal factorialK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        {
        for (int i = 1; i <= k; i++)
            factorialK *= i;
        }
        decimal factorialSum = (factorialN / factorialK);
        Console.WriteLine(factorialSum);
        
    }
}

