using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
/// <summary>
/// Mergosort normally devides all elements in separate arrays
/// considering array of 1 el is sorted
/// Than we compare the arrays and merge them.
/// </summary>
class MergeSort
{
    public static int[] MergeSortAction(int[] input)
    {
        int length = input.Length;

        if (length == 1)
        {
            return input;
        }

        int middle = length / 2;
        int[] leftArr = new int[middle];
        int[] rightArr = new int[length - middle];
        Array.Copy(input, 0, leftArr, 0, middle);
        Array.Copy(input, middle, rightArr, 0, length - middle);
        leftArr = MergeSortAction(leftArr);
        rightArr = MergeSortAction(rightArr);
        int[] sortedArray = new int[length];
        int leftIndex = 0;
        int rightIndex = 0;
        for (int i = 0; i < length; i++)
        {
            if (rightIndex == rightArr.Length || (leftIndex < leftArr.Length && leftArr[leftIndex] <= rightArr[rightIndex]))
            {
                sortedArray[i] = leftArr[leftIndex];
                leftIndex++;
            }
            else if (leftIndex == leftArr.Length || (rightIndex < rightArr.Length && rightArr[rightIndex] <= leftArr[leftIndex]))
            {
                sortedArray[i] = rightArr[rightIndex];
                rightIndex++;
            }
        }

        return sortedArray;
    }

    static void Main()
    {
        int[] myArr = { 2, 20, -100, 23, 12, 5, 1, 0, 44, 1234, -3454, -4, 123 };
        Console.WriteLine("Array: ");
        foreach (var item in myArr)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();

        int[] newArr = MergeSortAction(myArr);

        Console.WriteLine("Sorted array:");
        foreach (var item in newArr)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }
}

