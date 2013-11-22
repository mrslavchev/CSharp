//Write a program that reads two integer numbers N and K and an array of N 
//elements from the console. Find in the array those K elements that have maximal sum.

using System;
using System.Text;
/// <summary>
/// Sort the array and print all values standing from length -3 to the end
/// 
/// </summary>
class MaxSumOfKElements
{
    static void Main()
    {
        Console.WriteLine("Please enter value for K:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for N:");
        int n = int.Parse(Console.ReadLine());
        int[] arrN = new int[n];
        Random filler = new Random();
        Console.WriteLine("Array is:");
        for (int i = 0; i < arrN.Length; i++)
        {
            arrN[i] = filler.Next(-100, 100);

            Console.Write(arrN[i] + ", ");// read input fill the array with random values

        }
        Console.WriteLine();

        int bestSum = 0;
        Array.Sort(arrN);
        Console.WriteLine("Numers are:");
        for (int i = arrN.Length -k; i < arrN.Length; i++)
        {
            bestSum = bestSum + arrN[i];
            Console.Write(arrN[i] + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("Best sum is: " + bestSum);


    }
}