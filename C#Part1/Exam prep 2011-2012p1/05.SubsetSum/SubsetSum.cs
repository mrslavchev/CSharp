using System;

class SubsetSum
{
    static void Main()
    {
        long finalSum = long.Parse(Console.ReadLine());
        long n = long.Parse(Console.ReadLine());
        long[] array = new long[n + 1];
        long result = 0;
        for (long i = 0; i < n; i++)
        {
            array[i] = long.Parse(Console.ReadLine());
        }

        for (int i = (int)Math.Pow(2, (double)n) - 1; i > 0; i--)
        {
            long sum = 0;
            for (int y = 0; y < n; y++)
            {
                if (((i >> y) & 1) == 1)
                {
                    sum += array[y];
                }
            }

            if (sum == finalSum)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}