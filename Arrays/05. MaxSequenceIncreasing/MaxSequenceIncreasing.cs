//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// Iterate array from second element comparing it to the previous one
/// if bigger we add the prevoious, if not we check corner case 1 and 2
/// and clean temporary variables (count, sequence)
/// </summary>
class MaxSequenceIncreasing
{
    static void Main()
    {
        int[] numArray = { 3, 2, 3, 4, 2, 2, };
        int count = 1;
        int bestCount = 0;
        StringBuilder sequence = new StringBuilder();
        string bestSequence = "";

        for (int i = 1; i < numArray.Length; i++)
        {
            if (numArray[i - 1] < numArray[i])
            {
                count++;
                if (count > bestCount)
                {
                    bestCount++;
                    sequence.Append(numArray[i - 1]);
                    bestSequence = sequence.ToString();
                }              
                else
                {
                    sequence.Append(numArray[i - 1]);
                }
            }
            else if (count > bestCount && bestCount != 0) // corner case 1 for the last elem in internat sequence
            {
                bestCount = count;
                sequence.Append(numArray[i - 1]);
                bestSequence = sequence.ToString();
            }
            else
            {
                count = 1;
                sequence.Clear();
            }
            //corner case 2 if sequence ends at array.Length-1
            if (numArray[i-1] < numArray[i] && i == numArray.Length-1) 
            {
                sequence.Append(numArray[i]);
                bestSequence = sequence.ToString();
            }
        }

        bestSequence.ToArray();
        Console.Write("{");
        foreach (var num in bestSequence)
        {
            Console.Write(num + ", ");
        }
        Console.Write("}");
        Console.WriteLine();
    }

}
