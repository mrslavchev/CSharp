using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?

/// <summary>
/// Using Kadane's algorithm here, it's simple:
/// We store the sum in temp variable if it exceeds best sum
/// bestSum = tempSum and we store the sequence in a string. Otherways we 
/// clear both tempSum and tempSeq
/// </summary>
class LargestSubset
{
    static void Main()
    {
        int[] numsArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
        int tempSum = 0;
        int biggestSum = int.MinValue;
        StringBuilder tempSequence = new StringBuilder();
        string bestSequnce = "";
        for (int i = 0; i < numsArray.Length; i++)
        {
            tempSum = tempSum + numsArray[i];
            tempSequence.AppendFormat("{0}, ", numsArray[i]);
            if (tempSum > biggestSum)
            {
                biggestSum = tempSum;
                bestSequnce = tempSequence.ToString();
            }

            if (tempSum < 0)
            {
                tempSum = 0;
                tempSequence.Clear();
            }
        }

        Console.WriteLine("Sequence: \" {0} \" ", bestSequnce);
        Console.WriteLine("Sum: {0} ", biggestSum);
    }
}

