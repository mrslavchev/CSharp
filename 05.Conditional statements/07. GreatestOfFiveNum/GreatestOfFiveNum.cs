using System;
using System.Threading;
using System.Globalization;


class GreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        double biggest = double.Parse(Console.ReadLine());
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Please enter a number: ");
            double number = double.Parse(Console.ReadLine());
            if (number>biggest)
            {
                biggest = number;
            }
        }
        Console.WriteLine("The biggest number is: {0}",biggest);
    }
}
