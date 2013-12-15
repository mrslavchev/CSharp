using System;
//Write a program that finds the maximal sequence of equal elements in an array.
//              Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}

/// <summary>
/// We compare the current element with the next, if they match
/// we increase count, if they dont we bring count back to 1
/// If count exceeds bestCount we replace bestCount and repeatedNum with current num
/// At the end we make a check, if we dont have sequence of at least 2 elements
/// we print message.
/// </summary>
class MaxSequenceEquals
{
    static void Main()
    {
        int[] numArray = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int repeatedNum = numArray[0] ;
        int count = 1;
        int bestCount = 1;
        for (int i = 0; i < numArray.Length-1; i++)
        {
            if (numArray[i] == numArray[i+1])
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
            Console.WriteLine("No sequence found");
        }
        else
        {
            Console.Write("{");
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(repeatedNum);
            }

            Console.WriteLine("}");
            Console.WriteLine();
        }
    }
}