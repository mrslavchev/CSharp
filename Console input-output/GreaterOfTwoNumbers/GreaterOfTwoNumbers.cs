using System;

/// <summary>
/// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
/// </summary>
class GreaterOfTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number to compare:");
        double num2 = double.Parse(Console.ReadLine());
        bool res = (num>num2);
        Console.WriteLine("And the bigger number is: "+(res? num:num2));
    }
}

