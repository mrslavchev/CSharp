using System;

class Print1ToNNonDivisableTo3And7
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            int dividedBy3and7 = (i % 21);
            if (dividedBy3and7 != 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("The End!");
    }
}

