using System;

class Methods
{
    static void Main()
    {
        Console.WriteLine("how many integers?");
        //int numbers = int.Parse(Console.ReadLine());
        int[] arr = { 2, 3, 5, 123, 1, 2, 3, 51, 213 };//new int[numbers];

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine("enterr number {0}",i+1);
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        Console.WriteLine("the minimum is {0}", MinimumValue(arr));
        Console.WriteLine("the maxmimum is {0}", MaximumValue(arr));
        Console.WriteLine("the average number is {0}", AverageValue(arr));
        Console.WriteLine("the sum is {0}", Sum(arr));
        Console.WriteLine("the product is {0}", Product(arr));
    }

    static int MinimumValue(int[] arr)
    {

        int minimum = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < minimum)
            {
                minimum = arr[i];
            }
        }
        return minimum;
    }

    static int MaximumValue(int[] arr)
    {

        int maxmimum = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxmimum)
            {
                maxmimum = arr[i];
            }
        }
        return maxmimum;
    }

    static double AverageValue(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / 2;
    }

    static long Sum(int[] arr)
    {
        long sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static long Product(int[] arr)
    {
        long product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
}