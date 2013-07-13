// Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
 
using System;

class QuickSort
{
    static void Main(string[] args)
    {
        string[] unsorted = { "son of a...", "dog", "cat", "bull", "quicksort","parrot" };
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }
        Console.WriteLine();
        
        Quicksort(unsorted, 0, unsorted.Length - 1);
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Quicksort(string[] elements, int left, int right)
    {
        int i = left, j = right;
        string middle = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(middle) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(middle) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                string temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;

                i++;
                j--;
            }
        }
    }
}