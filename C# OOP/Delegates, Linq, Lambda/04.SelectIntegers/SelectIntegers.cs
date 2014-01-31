using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SelectIntegers
{
    /*Assuming that the author of the task meant 
     the number should be devisible by 7 and 3 at the same time
     which excludes numbers divisible by 3 only or 7 only */
    static void Main(string[] args)
    {
        int[] numbers = new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 14, 21, 53, 39, 42 };

        // Select with lambda
        var divisible = numbers.Where(n => n % 21 == 0);
        Console.WriteLine("Select with lambda");
        foreach (var item in divisible)
        {
            Console.WriteLine("\t" + item);
        }

        // Select with LINQ

        Console.WriteLine("Select with LINQ");
        var divisible2 =
            from n in numbers
            where n % 21 == 0
            select n;
        foreach (var item in divisible2)
        {
            Console.WriteLine("\t" + item);
        }
    }
}

