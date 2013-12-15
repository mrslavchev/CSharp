//Write a program that reads two arrays from the console and compares them element by element.
using System;

class CompareTwoArrays
{   // Using a separate method to fill and read ints from the console
    static int[] ReadNumbers ()
    {
        Console.WriteLine("Please enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int [] arr = new int [n];
        Console.WriteLine("Pleaase enter {0} numbers",n);
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        return arr;
    }

    static void Main()
    {
        int[] firstArr = ReadNumbers();
        int[] secondArr = ReadNumbers();
        int matchCount = 0;
        if (firstArr.Length == secondArr.Length)
        {
            Array.Sort(firstArr);
            Array.Sort(secondArr);
            Console.WriteLine();
            for (int i = 0; i < firstArr.Length; i++)                // If lengths are equal we compare each
            {                                                        // two corresponding elements
                if (firstArr[i] == secondArr[i])                     // If their count equals element count
                {                                                    // arrays match. If we have a case
                    matchCount += 1;                                 // with same array but in different order
                    if (matchCount == firstArr.Length)               // we may solve it with sorting both arrays
                    {
                        Console.WriteLine("The two arrays match");
                    }
                }
         
                else
                {
                    Console.WriteLine("The two arrays don't match");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("The two arrays don't match");
        }
    }
}

