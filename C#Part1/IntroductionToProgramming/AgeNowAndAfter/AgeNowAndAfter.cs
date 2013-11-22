using System;

class AgeNowAndAfter
{
    static void Main()
    {
        Console.WriteLine("Please write down your age:");
        int age = int.Parse(Console.ReadLine());
        age += 10;
        Console.WriteLine("Your age in 10 years will be: {0} years", age);
    }
}
