using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

class DurankulakNumbers
{

    public static string[] CreateDigits()
    {
        char letter = 'A';
        string[] digits = new string[200];
        int counter = 0;
        for (int i = 0; i < 26; i++)
        {
            letter = (char)('A' + i);
            digits[i] = letter.ToString();
            //Console.WriteLine("INdex {0} number {1}", i, digits[i]);
            counter++;
        }

        StringBuilder builder = new StringBuilder();
        char letter2 = 'B';
        for (int i = 0; i < 6; i++)
        {
            letter = (char)('a' + i);
            for (int k = 0; k < 26; k++)
            {
                letter2 = (char)('A' + k);
                builder.Append(letter);
                builder.Append(letter2);
                digits[counter] = builder.ToString();
                //Console.WriteLine("INdex {0} number {1}", counter, digits[counter]);
                builder.Clear();
                counter++;
            }   
        }
        return digits;
    }

    public static BigInteger CalculateSum(string[] arr, string str)
    {
        string regex = @"[A-Z]|[a-z][A-Z]";
        MatchCollection matches = Regex.Matches(str, regex);
        BigInteger sum = 0;
        int power = 0;
        string search = "";
        for (int i = 0; i < matches.Count; i++)
        {
            power = matches.Count - 1 - i;
            search = matches[i].ToString();
            sum += Array.IndexOf(arr, search) * (BigInteger)Math.Pow(168, power);
        }
        return sum;
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] digits = CreateDigits();
        Console.WriteLine(CalculateSum(digits, input));
    }
}

