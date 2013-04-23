using System;

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
        decimal subs = (n - k);
        decimal factorialSubs = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        {
            for (int i = 1; i <= k; i++)
                factorialK *= i;
        }
        decimal factorialProduct = (factorialN * factorialK);
        for (int i = 1; i <= subs; i++)
        {
            factorialSubs *= i;
        }
        decimal factorialFinal = (factorialProduct / factorialSubs);
        Console.WriteLine(factorialFinal);

    }
}
