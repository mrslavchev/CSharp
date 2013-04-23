using System;

class IsLeap
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        if (now.Year % 4 == 0)
        {
            Console.WriteLine("Current year is leap");
        }
        else
        {
            Console.WriteLine("Current year is not leap");
        }
    }
}

