﻿using System;
using System.Linq;
using System.Diagnostics;

/*Following the paradigm that assertions should check the programmer's logic, 
 we only assert the private methods, to check whether or not our assumptions are true.*/
public class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        for (int index = 0; index < arr.Length-1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }
  
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(startIndex >= 0, "Start index can not be negative.");
        Debug.Assert(startIndex <= endIndex, "Start index can not be bigger than end index");
        Debug.Assert(arr.Length > 0, "Array is empty");
        Debug.Assert(arr != null, "Array is null");
        Debug.Assert(endIndex <= arr.Length - 1, "End index out of range.");
        Debug.Assert(endIndex >= 0, "End index can not be negative.");
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(x != null || y != null, "Argument can not be null.");
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0, "Array has 0 elements");
        Debug.Assert(arr != null, "Array is null");
        Debug.Assert(arr[0].GetType() == value.GetType(), "Collection and value types mismatch");
        Debug.Assert(value != null, "Value is null.");
        Debug.Assert(startIndex >= 0, "Start index can not be negative");
        Debug.Assert(startIndex <= endIndex, "Start index can not be bigger than end index.");
        Debug.Assert(endIndex <= arr.Length - 1, "End index out of bounds.");
        Debug.Assert(endIndex >= 0, "End index can not be negative.");
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
