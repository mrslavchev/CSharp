/*Implement a set of extension methods for IEnumerable<T> that 
implement the following group functions: sum, product, min, max, average.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int[] example = new int[132312];

        for (int i = 0; i < example.Length; i++)
        {
            example[i] = (example.Length - i) -1;
        }

        Console.WriteLine("Minimum number is: "+ example.Min());
        Console.WriteLine("Maximum number is: "+ example.Max());
        Console.WriteLine("Avarage of all numbres is: " + example.Average());
        Console.WriteLine("And their sum is: " + example.Sum());
    }
}

