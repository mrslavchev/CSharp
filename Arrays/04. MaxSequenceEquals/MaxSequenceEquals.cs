//Write a program that finds the maximal sequence of equal elements in an array.
//              Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}
using System;



class MaxSequenceEquals
{
    static void Main()
    {
        int repeatedNumb = int.MinValue;
        int counter = 0;
        int repetition = 0;
        int[] digitsArray = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        for (int i = 0; i < digitsArray.Length; i++)
        {
            if ((i < digitsArray.Length -1) && (digitsArray [i] == digitsArray [i+1]))
            {
                counter++;
            }

            else 
            {
                if (counter > repetition)
                {
                    repetition = counter;
                    repeatedNumb = digitsArray[i];
                    counter = 0;
                }
            }
        }
        for (int i = 0; i < repetition; i++)
        {
            Console.Write(repeatedNumb);
        }
        Console.WriteLine();
    }
}