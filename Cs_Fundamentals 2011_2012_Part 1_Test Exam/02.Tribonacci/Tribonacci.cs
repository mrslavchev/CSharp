using System;
using System.Collections.Generic;
using System.Numerics;

class Tribonacci
{
    static void Main(string[] args)
    {
        List<BigInteger> numbers = new List<BigInteger>();
        for (int i = 0; i < 3; i++)
        {
            numbers.Add(BigInteger.Parse(Console.ReadLine()));
        }

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (n < 4)
            {
                Console.WriteLine(numbers[n - 1]);
                return;
            }
            else if (i < 3)
            {
                continue;
            }
            else
            {
                numbers.Add(numbers[i - 1] + numbers[i - 2] + numbers[i - 3]);
                if (i == n - 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}

