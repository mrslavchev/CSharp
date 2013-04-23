//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MostFrequent
{
    class MostFrequent
    {
        static void Main()
        {
            int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            Array.Sort(numbers);
            int currentCount = 1;
            int bestCount = 1;
            int mostFrequentNumber = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentCount++;
                    bestCount = currentCount;
                    mostFrequentNumber = numbers[i];
                }
                else
                {
                    currentCount = 1;
                }
            }

            Console.Write(mostFrequentNumber+", ");
            Console.WriteLine(bestCount+" times");
        }
    }
}