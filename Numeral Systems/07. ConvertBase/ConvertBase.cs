using System;
using System.Collections.Generic;
/*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/
public class ConvertBase
{
    private static Dictionary<char, int> numericSymbols = new Dictionary<char, int>()
    {
        {'0', 0}, {'1', 1}, {'2', 2}, {'3', 3}, {'4', 4}, {'5', 5}, {'6', 6}, {'7', 7},
        {'8', 8}, {'9', 9}, {'A', 10}, {'B', 11}, {'C', 12}, {'D', 13}, {'E', 14}, {'F', 15},
    };

    static int Readbase() 
    {
        Console.WriteLine("Please enter the base of the numeric system:");
        int numBase = int.Parse(Console.ReadLine());
        if (numBase < 2 || numBase > 16)
        {
            throw new ArgumentException();
        }

        return numBase;
    }

    static int SbaseToDecimal(string input, int sBase) 
    {
        for (int i = 0; i < input.Length; i++)
        {
            
        }
    }

    /*
    static string DecimalToDbase(int tempDecimal) 
    {
    }

   */

    static void Main()
    {
        int s = Readbase();
        string input = Console.ReadLine();
        int d = Readbase();
        //int tempDecimal = SbaseToDecimal(input);
        //string output = DecimalToDbase(tempDecimal);
        Console.WriteLine(s + " " + d);
    }
}