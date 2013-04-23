using System;


class DayOfTheWeek
{
    static void Main(string[] args)
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Today is {0}", today.DayOfWeek);
    }
}

