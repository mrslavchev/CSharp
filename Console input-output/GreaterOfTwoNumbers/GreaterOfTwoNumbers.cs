using System;

class GreaterOfTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number to compare:");
        double num2 = double.Parse(Console.ReadLine());
        bool res = (num>num2);
        while (num==num2)
        {
            Console.WriteLine("The two numbers are equal, if you want to compare, choose different ones");
            return;
        }
        Console.WriteLine("And the bigger number is: "+(res? num:num2));
    }
}

