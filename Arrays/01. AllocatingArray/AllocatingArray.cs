//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
//Print the obtained array on the console.

using System;

class AllocatingArray
{
    static void Main()
    {
        Console.WriteLine("Please enter 20 integers:");
        int[] integers =new int [20];
        for (int index = 0; index < integers.Length; index++)
        {
            integers[index] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Initialised values are: ");
        for (int i = 0; i < integers.Length; i++)
        {
            integers[i] = i * 5;
            Console.WriteLine(integers[i]);
        }
    }
}

