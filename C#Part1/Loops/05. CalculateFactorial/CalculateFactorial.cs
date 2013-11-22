using System;

/// <summary>
/// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
/// </summary>
class KDividesNFactorial
{
    static void Main()
    {
        Console.WriteLine("Please enter value for N: ");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for K: ");
        long k = long.Parse(Console.ReadLine());
        long factorialN = 1;
        long factorialK = 1;
        long subs = (n - k);
        long factorialSubs = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        
        for (int i = 1; i <= k; i++)
        {
                factorialK *= i;
        }

        long factorialProduct = (factorialN * factorialK);
        for (int i = 1; i <= subs; i++)
        {
            factorialSubs *= i;
        }

        long factorialFinal = (factorialProduct / factorialSubs);
        Console.WriteLine(factorialFinal);

    }
}
