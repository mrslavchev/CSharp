//Write a program that reads two arrays from the console and compares them element by element.
using System;

class CompareTwoArrays
{
    static int[] ReadingNumbers ()
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
        int[] integers = ReadingNumbers();
        int[] numbers = ReadingNumbers();
        int matchCount = 0;
        if (integers.Length == numbers.Length)
        {
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] == numbers[i])
                {
                    matchCount += 1;
                }
                else if (matchCount == integers.Length)
                {
                    Console.WriteLine("The two arrays match");
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

