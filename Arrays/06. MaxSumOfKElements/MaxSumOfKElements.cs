﻿using System;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter arrays size");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter subset to be checked");
        int k = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        string bestSeq = "";
        int sum = 0;
        int bestSum = int.MinValue;
        int arrayLen = myArray.Length;
        for (int i = 0; i < arrayLen; i++)
        {
            string currentSeq = "";
            if (i + k > arrayLen)
            {
                break;
            }
            
            for (int j = i; j < i + k; j++)
            {
                sum = sum + myArray[j];
                currentSeq = currentSeq + ' ' + myArray[j];
            }
            
            if (sum > bestSum)
            {
                bestSeq = currentSeq;
                bestSum = sum;
            }
            sum = 0;
        }
        Console.WriteLine("The subset is " + bestSeq);
        Console.WriteLine("Its sum is " + bestSum);
    }
}