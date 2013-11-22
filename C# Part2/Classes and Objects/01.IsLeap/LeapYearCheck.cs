using System;
/*Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
*/
/// <summary>
/// The algorithm is each 4 ears we have 1 leap, expecpt for each 100, except for each 400.
/// </summary>
class LeapYearCheck
{
    static void Main()
    {
        Console.WriteLine("Please write a date in format: YYYY/MM/DD or DD/MM/YYYY");
        DateTime year = DateTime.Parse(Console.ReadLine());
        if (year.Year % 4 == 0)
        {
            if (year.Year % 100 == 0)
            {
                if (year.Year % 400 == 0)
                {
                    Console.WriteLine("Is leap year");
                    return;
                }

                Console.WriteLine("Is not a leap year");
                return;
            }

            Console.WriteLine("Is leap year");
        }
        else
        {
            Console.WriteLine("Is not a leap year");
        }
    }
}

