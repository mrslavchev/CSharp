using System;
using System.Linq;
using System.Collections.Generic;

/*Write a method that calculates the number of workdays between today and given date, passed as parameter.
 Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/
/// <summary>
/// Array of official holidays and method calculating work days
/// </summary>
class NumberOfWorkDays
{
    /// <summary>
    /// Using the dates just until the end of the year
    /// </summary>
    private static DateTime[] officialHolidays =
    {
        new DateTime(2013, 09, 06),
        new DateTime(2013, 09, 22),
        new DateTime(2013, 12, 24),
        new DateTime(2013, 12, 25),
        new DateTime(2013, 12, 26),
        new DateTime(2013, 12, 31),
    };

    /// <summary>
    /// While today is != than the input date, we increase it. We are adding a date in the list
    /// at certain conditions 1. If its not == holiday and 2. if it's not Saturday or Sunday
    /// </summary>
    /// <param name="input">Takes date time as input parameter</param>
    /// <returns>Int count of work days</returns>
    static int CountWorkDays(DateTime input) 
    {
        DateTime today = DateTime.Now.Date;
        List<DateTime> workDays = new List<DateTime>();
        while (today != input)
        {
            for (int i = 0; i < officialHolidays.Length; i++)
            {
                if (today == officialHolidays[i])
                {
                    today = today.AddDays(1);
                    continue;
                }
            }

            if (today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday)
            {
                today = today.AddDays(1);
            }
            else
            {
                workDays.Add(today);
                today = today.AddDays(1);
            }
        }

        return workDays.Count;
    }

    static void Main()
    {
        Console.WriteLine("Please write a date in format DD/MM/YYYY");
        DateTime inputdate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Number of workdays left to that date: ");
        Console.WriteLine(CountWorkDays(inputdate));
    }
}
        
    

