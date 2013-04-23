using System;

class AgeNowAndAfter
{
    static void Main()
    {
        Console.WriteLine("Please enter your age.");
        int value;
        if (int.TryParse(Console.ReadLine(), out value) && value >=1 && value < 150)
        {
            Console.WriteLine("After 10 Years you will be at " + (value + 10) + " Years");
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}
