using System;
/*Write a method that counts how many times given number appears in given array. 
 * Write a test program to check if the method is working correctly.
*/
class AppearencesCounter
{
    static int NumberCounter(int[] arr, int num)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 2, 1, 4 };
        int n = 4;
        Console.WriteLine(NumberCounter(arr, n));
    }
}