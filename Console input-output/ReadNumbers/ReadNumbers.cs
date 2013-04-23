using System;

class ReadNumbers
{
    static void Main()
    {
        Console.WriteLine("Please type a number:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Please type another number:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please type third number:");
        int num3 = int.Parse(Console.ReadLine());
        int sum = (num+num2+num3);
        Console.WriteLine("And the result is:"+sum);
    }
}

