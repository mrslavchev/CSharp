//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//Print the result string into the console.

using System;

/// <summary>
/// We use padright, and fill the length woth asterix if it's less than 20 chars.
/// </summary>
class String20Chars
{
    static void Main()
    {
        Console.WriteLine("Please write a string of maximum 20 chars.");
        string input = Console.ReadLine();
        int maxLength = 20;

        if (input.Length <= maxLength)
        {
            Console.WriteLine(input.PadRight(maxLength, '*'));
        }
        else
        {
            Console.WriteLine("Input is too long!");
        }
    }
}
