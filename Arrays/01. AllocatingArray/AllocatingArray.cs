//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
//Print the obtained array on the console.

using System;

class AllocatingArray
{
    static void Main()
    {
        int[] integerArray = new int[20];
        Random filler = new Random();
        for (int i = 0; i < integerArray.Length; i++)// a lazy way to fill the array with random
        {                                            // values we use ramdom generator and add
            int fill = filler.Next(0, 100);          // one random value 0-100 on each iteration
            integerArray[i] = fill;                  
        }

        Console.WriteLine("Primary array:");
        foreach (var item in integerArray)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
        for (int i = 0; i < integerArray.Length; i++)
        {
            integerArray[i] = i * 5;
        }

        Console.WriteLine("Modified array::");
        foreach (var item in integerArray)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }
}

