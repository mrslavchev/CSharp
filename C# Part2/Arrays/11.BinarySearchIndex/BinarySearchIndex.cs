using System;

//Write a program that finds the index of
//given element in a sorted array of integers
//by using the binary search algorithm (find it in Wikipedia).
class BinarySearchIndex
{
    /// <summary>
    /// Sort array, than make a devision point = biigest + smallest number /2
    /// if our number is smaller we exclude all bigger, if it's bigger we exclude
    /// all smaller, and repeat until we have a match
    /// </summary>
    /// <param name="array">The array we search in</param>
    /// <param name="key">The value which index we are looking for</param>
    /// <returns>index or -1 if no such value is contained</returns>
    static int BinarSearch(int[] array, int key)
    {
        Array.Sort(array);
        int maxIndex = array.Length - 1;
        int minIndex = 0;
        while (maxIndex >= minIndex)
        {
            int middleIndex = (minIndex + maxIndex) / 2;
            if (array[middleIndex] < key)
            {
                minIndex = middleIndex + 1;
            }
            else if (array[middleIndex] > key)
            {
                maxIndex = middleIndex - 1;
            }
            else
            {
                return middleIndex;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] myArray = { 4, 3, 1, 4, 2, 5, 8, 21, 13, 180 };
        int key = 8;
        foreach (var item in myArray)
        {
            Console.Write(item + ", ");
        }

        Console.WriteLine();
        Console.WriteLine("The key is: {0}", key);
        Console.WriteLine("The index is: " + BinarSearch(myArray, key));
        //Good to know is the Array class has implemented binsearch method too.
        Console.WriteLine(Array.BinarySearch(myArray, key));
    }
}