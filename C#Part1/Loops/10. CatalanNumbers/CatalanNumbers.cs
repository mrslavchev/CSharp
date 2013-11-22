using System;
using System.Numerics;

/// <summary>
/// Write a program to calculate the Nth Catalan number by given N.
/// </summary>
class CatalanNumbers
{
    static BigInteger FactorialCalc(BigInteger number)
    {
        BigInteger sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum = sum * i;
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Please enter which Catalan number you want to see? ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger CatalanSum = 0;
        CatalanSum = FactorialCalc(2 * n) / (FactorialCalc(n + 1) * FactorialCalc(n));
        Console.WriteLine("The {0}-th Catalan number is: {1}",n,CatalanSum);
    }
}