using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

/// <summary>
/// Exact same algorithm as task 4, just sort the array before start iterating.
/// </summary>
class MostFrequent
{
    static void Main()
    {
        int[] numArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int repeatedNum = numArray[0];
        int count = 1;
        int bestCount = 1;
        Array.Sort(numArray);
        for (int i = 0; i < numArray.Length - 1; i++)
        {
            if (numArray[i] == numArray[i + 1])
            {
                count++;
                if (count > bestCount)
                {
                    bestCount = count;
                    repeatedNum = numArray[i];
                }
            }
            else
            {
                count = 1;
            }
        }

        if (bestCount < 2)
        {
            Console.WriteLine("No repetition");
        }
        else
        {
            Console.WriteLine(repeatedNum + " ({0} times)", bestCount);
        }
    }
}