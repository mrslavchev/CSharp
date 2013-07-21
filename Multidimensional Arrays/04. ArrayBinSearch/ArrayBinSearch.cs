/* Write a program, that reads from the console an array of N integers and an integer K,
 sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. */

using System;
using System.Linq;

class ArrayBinSearch
{
    static void Main()
    {
        Console.WriteLine("Input value for n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Input value for {0} element", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Input value for k: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("The array is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine();

        Array.Sort(array);
        int index = Array.BinarySearch(array, k);
        int result = 0;
        if (array[0] > k)
        {
            Console.WriteLine("No smaller or even number in the array");
        }
        else
        {
            if (index >= 0)
            {
                result = array[index];
                Console.WriteLine("The biggest or equal number is: " + result);
            }
            else
            {
                result = array[~index - 1];
                Console.WriteLine("The biggest or equal number is: " + result);
            }
        }
        
    }
}