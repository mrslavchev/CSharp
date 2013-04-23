//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


using System;
using System.Collections.Generic;



class MaxSequenceIncreasing
{
    static void Main()
    {
        int[] digitsArray = { 3, 2, 3, 4, 2, 2, 4 };
        int counter = 1;
        int repetition = 0;
        int largestInSequence = 0;
        for (int i = 0; i < digitsArray.Length - 1; i++)
        {
            if (digitsArray[i] < digitsArray[i + 1])
            {
                counter++;
            }
            else
            {
                if (counter > repetition)
                {
                    repetition = counter;
                    largestInSequence = i;
                }
                counter = 1;
            }
        }

        if (counter > repetition)
        {
            repetition = counter;
            largestInSequence = digitsArray.Length - 1;
        }

        counter = 1;
        for (int i = largestInSequence - repetition + 1; i < largestInSequence + 1; i++)
        {
            Console.Write("{0},", digitsArray[i]);
        }
        Console.WriteLine();
    }
}

