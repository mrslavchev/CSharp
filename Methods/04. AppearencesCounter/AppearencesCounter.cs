using System;

class AppearencesCounter
{
    static int FindHowManyTimesNumAppear(int[] arr, int arrLength, int num)
    {
        int counter = 0;
        for (int i = 0; i < arrLength; i++)
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
        int arrLength = arr.Length;
        int n = 1;
        Console.WriteLine(FindHowManyTimesNumAppear(arr, arrLength, n));
    }
}