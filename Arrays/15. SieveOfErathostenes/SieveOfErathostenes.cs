//ite a program that finds all prime numbers
// the range [1...10 000 000]. Use the sieve
// Eratosthenes algorithm (find it in Wikipedia).
//

using System;
/// <summary>
/// Using the Sieve of erathostenes we plant 
/// true values in an array with 10000000 elements
/// Than iterate and chech if index == true, print
/// </summary>
class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] primes = new bool[10000000];
        for (int i = 2; i < Math.Sqrt(primes.Length); i++)
        {
            if (primes[i] == false)
            {
                for (int j = i * i; j < primes.Length; j = j + i)
                {
                    primes[j] = true;
                }
            }
        }
        for (int i = 2; i < primes.Length; i++)
        {
            if (primes[i] == false)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}