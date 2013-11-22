using System;
using System.Collections.Generic;

class TribonacciTriangle
{
    /// <summary>
    /// Finds the linear position of tribonacci number in n x n tribonacci triangle
    /// </summary>
    /// <param name="n">Number</param>
    /// <returns>Sum of numbers from 1 to n</returns>
    public static int FindTriangularNumber(int n)
    {
        int sum = 0;
        if (n == 2)
        {
            return 3;
        }
        else
        {
            while (n != 0)
            {
                sum += n;
                n--;
            }
            return sum;
        }
    }

    /// <summary>
    /// Calculates tribnacci sequence with length elemnts
    /// </summary>
    /// <param name="nums">Takes first three numbers as parameters</param>
    /// <param name="length">The length the list should be extended to</param>
    /// <returns>New list of tribonacci numbers</returns>
    public static List<long> CalcTribonacci(List<long> nums, int length)
    {
        List<long> output = nums;
        for (int i = 3; i < length; i++)
        {
            output.Add(nums[i - 1] + nums[i - 2] + nums[i - 3]);
        }

        return output;
    }

    /// <summary>
    /// Prints triangle on the console
    /// </summary>
    /// <param name="sequence">Takes list of longs as first parameter</param>
    /// <param name="lines">Numbers of lines, triangle should reach</param>
    public static void WriteTriangle(List<long> sequence, int lines)
    {
        int count = 0;
        for (int row = 1; row <= lines ; row++)
        {
            for (int cols = 0; cols < row; cols++)
            {
                if (cols == row -1)
                {
                    Console.Write(sequence[count]);
                    count++;
                }
                else
                {
                    Console.Write(sequence[count] + " ");
                    count++;
                }
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        List<long> tribonachos = new List<long>();
        tribonachos.Add(long.Parse(Console.ReadLine()));
        tribonachos.Add(long.Parse(Console.ReadLine()));
        tribonachos.Add(long.Parse(Console.ReadLine()));
        int l = int.Parse(Console.ReadLine());
        int len = FindTriangularNumber(l);
        tribonachos = CalcTribonacci(tribonachos, len);
        WriteTriangle(tribonachos, l);
    }
}

