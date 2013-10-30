using System;

/// <summary>
/// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
/// </summary>
class PrimeNumbers
{
    static void Main()
    {
        Console.WriteLine("Plese write a number between 1 and 100 and check if its prime");
        byte num = byte.Parse(Console.ReadLine());
        if (num < 2)
        {
            Console.WriteLine("1 isn't a prime number");
            return;
        }

        byte sqrt = (byte)Math.Sqrt(num);
        byte div = 2;
        bool prime = true;
        while (prime && (div <= sqrt))
        {
            if (num % div == 0) 
            {
                prime = false;
            }

            div++;
        }

        Console.WriteLine("Is {0} a prime number? {1}",num,prime);

    }
}

