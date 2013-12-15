using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    //Sorting an array means to arrange its elements in increasing order. Write a program 
    //to sort an array. Use the "selection sort" algorithm: Find the smallest element, 
    //move it at the first position, find the smallest from the rest, move it at the second position, etc.

    /// <summary>
    /// Sorting merthod compares first element with the smallest of all other
    /// if j < min its replaced
    /// And it goes on
    /// </summary>
    public class Selectionsort
    {
        public static int[] SortArray(int[] array)
        {
            int i, j, min, temp;
            for (i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
            return array;
        }

        static void Main()
        {
            int[] integerArray = new int[20];
            Random filler = new Random();
            for (int i = 0; i < integerArray.Length; i++)   // a lazy way to fill the array with random
            {                                               // values we use ramdom generator and add
                int fill = filler.Next(-100, 1000);         // one random value 0-100 on each iteration
                integerArray[i] = fill;
            }

            Console.WriteLine("Unsorted array:");
            foreach (var item in integerArray)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            SortArray(integerArray);

            foreach (var item in integerArray)
            {
                Console.WriteLine(item);
            }
        }
    }
