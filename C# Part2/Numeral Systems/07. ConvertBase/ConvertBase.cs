using System;
using System.Collections.Generic;
using System.Text;
/*Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
*/
/// <summary>
/// Logic is: we have method to read input and output base. Method to convert from input to decimal, and another from dec to output
/// </summary>
public class ConvertBase
{
    /// <summary>
    /// We use dictionary for the letter representation, each char(key) coresponds to int value
    /// </summary>
    private static Dictionary<char, int> numericSymbols = new Dictionary<char, int>()
    {
        {'0', 0}, {'1', 1}, {'2', 2}, {'3', 3}, {'4', 4}, {'5', 5}, {'6', 6}, {'7', 7},
        {'8', 8}, {'9', 9}, {'A', 10}, {'B', 11}, {'C', 12}, {'D', 13}, {'E', 14}, {'F', 15},
    };

    /// <summary>
    /// Reads integer values for base if value is <2 or > 16 throws an exception
    /// </summary>
    /// <returns>Int base</returns>
    static int Readbase() 
    {
        Console.WriteLine("Please enter the base of the numeric system:");
        int numBase = int.Parse(Console.ReadLine());
        if (numBase < 2 || numBase > 16)
        {
            throw new ArgumentException("Invalid base");
        }

        return numBase;
    }

    /// <summary>
    /// Converts sBase to decimal, using algorithm from ex.2
    /// </summary>
    /// <param name="input">Takes string input as first parameter</param>
    /// <param name="sBase">Takes numerical base as second parameter</param>
    /// <returns>lNumerical base</returns>
    static int SbaseToDecimal(string input, int sBase) 
    {
        int decSum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int position = input.Length - i - 1;
            if (input[i] == '0')
            {
                continue;
            }
            else
            {
                int value = numericSymbols[input[i]];
                decSum += (int)(value * Math.Pow(sBase, position));
            }
        }

        return decSum;
    }

    /// <summary>
    /// Uses same logic as ex.1, the specific part is, for each obtained value after % by DBase, we assign
    /// corresponding key from the dictionary. To make this we use extension method.
    /// </summary>
    /// <param name="tempDecimal">Takes string as first parameter</param>
    /// <param name="dBase">Takes output base as second parameter</param>
    /// <returns>String output in DBase</returns>
    static string DecimalToDbase(int tempDecimal, int dBase) 
    {
        List<int> tempDBase = new List<int>();
        while (tempDecimal != 0)
        {
            tempDBase.Add(tempDecimal % dBase);
            tempDecimal = tempDecimal / dBase;
        }

        tempDBase.Reverse();
        StringBuilder dBaseOutput = new StringBuilder();
        foreach (var value in tempDBase)
        {
            dBaseOutput.Append(numericSymbols.FindKeyByValue(value));
        }

        return dBaseOutput.ToString();
    }

   

    static void Main()
    {
        int s = Readbase();
        Console.WriteLine("Please write down a number in {0} numeral system", s);
        string input = Console.ReadLine();
        int d = Readbase();
        int tempDecimal = SbaseToDecimal(input, s);
        string output = DecimalToDbase(tempDecimal, d);
        Console.WriteLine("And the result in {0} base is \n{1}", d, output);
        
    }
}