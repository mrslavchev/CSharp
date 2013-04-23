//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class LargestSubset
{
    static void Main()
    {
        int[] numberArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int currentSum = 0;
        int biggestSum = int.MinValue;
        StringBuilder bestSequenceBuild = new StringBuilder();
        string bestSequnce = "";
        for (int i = 0; i < numberArray.Length; i++)
        {
            currentSum = currentSum + numberArray[i];
            bestSequenceBuild.AppendFormat("{0}, ", numberArray[i]);
            if (currentSum > biggestSum)
            {
                biggestSum = currentSum;
                bestSequnce = bestSequenceBuild.ToString();
            }
            if (currentSum < 0)
            {
                currentSum = 0;
                bestSequenceBuild.Clear();
            }
        }
        Console.WriteLine("Sequence: \" {0} \" ", bestSequnce);
        Console.WriteLine("Sum: {0} ", biggestSum);
    }
}

