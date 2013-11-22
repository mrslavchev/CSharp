using System;
using System.Globalization;
/*Write a program that reads a date and time given in the format: day.month.year hour:minute:second
 * and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/
class ReadDateAndTime
{
    static void Main()
    {
        Console.WriteLine("Please write a date and time in the format dd.mm.yyyy hh:mm:ss");
        DateTime input = DateTime.Parse(Console.ReadLine());
        input = input.AddHours(6.5);
        Console.WriteLine(input);
        Console.WriteLine(input.ToString("dddd", new CultureInfo("bg-BG")));
    }
}