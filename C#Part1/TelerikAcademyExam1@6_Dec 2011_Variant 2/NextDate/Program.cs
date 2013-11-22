
using System;

class Program
{
    static void Main(string[] args)
    {
        string day = Console.ReadLine();
        string month = Console.ReadLine();
        string year = Console.ReadLine();
        string format = "d.M.yyyy";
        DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
        date = date.AddDays(1);
        Console.WriteLine(date.ToString(format));
    }
}

