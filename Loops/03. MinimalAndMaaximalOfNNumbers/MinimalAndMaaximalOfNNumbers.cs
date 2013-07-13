using System;

class MinimalAndMaaximalOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter the count of numbers you want to compare: ");
        int count = int.Parse(Console.ReadLine());
        int maximal = int.MinValue;
        int minimal = int.MaxValue;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Please add a number: ");
            int newNumber = int.Parse(Console.ReadLine());
            if (newNumber > maximal)
            {
                maximal = newNumber;
            }
            if (newNumber < minimal)
            {
                minimal = newNumber;
            }
        }
        Console.WriteLine("Maximal {0} and minimal {1}", maximal, minimal);
    }
}

