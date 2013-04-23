using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that prints from given array of integers
all numbers that are divisible by 7 and 3. Use the built-in 
extension methods and lambda expressions. Rewrite the same with LINQ*/

class Program
{
    static void Main()
    {
        int[] numbers = new int[100];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }

        var caughtNumbers =
        from num in numbers
        where num % 21 == 0
        select num;
        //uncomment below and comment above to switch to lambda
        //var caughtNumbers = numbers.Where(x => x % 21 == 0);

        foreach (var num in caughtNumbers)
        {
            Console.WriteLine(num);
        }
    }
}

