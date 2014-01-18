using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

public static class Extension
{
    public static string ReplaceFirstOccurrance(this string original, string oldValue, string newValue)
    {
        if (String.IsNullOrEmpty(original))
            return String.Empty;
        if (String.IsNullOrEmpty(oldValue))
            return original;
        if (String.IsNullOrEmpty(newValue))
            newValue = String.Empty;
        int loc = original.IndexOf(oldValue);
        return original.Remove(loc, oldValue.Length).Insert(loc, newValue);
    }
}


public class EncodeAndEncrypt
{
    public static string Encode(string input)
    {
        string pattern = @"(\w)\1+";
        MatchCollection matches = Regex.Matches(input, pattern);
        int count = 0;
        for (int i = 0; i < matches.Count; i++)
        {
            string match = matches[i].ToString();
            count = match.Length;
            if (count > 2)
            {
                input = Extension.ReplaceFirstOccurrance(input, match, count.ToString() + match[0]);
            }
        }

        return input;
    }

    private static int GetLetterCode(char c)
    {
        int output = 0;
        output = char.ToLower(c) - 'A';

        return output;
    }

    public static string Encrypt(string msg, string cypher)
    {
        int msgLen = msg.Length;
        int cypLen = cypher.Length;
        int max = Math.Max(msgLen, cypLen);
        StringBuilder output = new StringBuilder();
        if (msgLen >= cypLen)
        {
            for (int i = 0; i < max; i++)
            {
                int a = GetLetterCode(msg[i]);
                int b = GetLetterCode(cypher[i % cypLen]);
                int c = a ^ b;
                char result = (char)(c + 'A');
                output.Append(result);
            }
        }
        else
        {
            for (int i = 0; i < cypLen; i++)
            {
                if (i < msgLen)
                {
                    int a = GetLetterCode(msg[i % msgLen]);
                    int b = GetLetterCode(cypher[i % cypLen]);
                    int c = a ^ b;
                    char result = (char)(c + 'A');
                    output.Append(result);
                }
                else
                {
                    int a = GetLetterCode(output[i % output.Length]);
                    int b = GetLetterCode(cypher[i % cypLen]);
                    int c = a ^ b;
                    char result = (char)(c + 'A');
                    output[i % output.Length] = result;
                }
            }
        }
        return output.ToString().ToUpper();
    }

    static void Main(string[] args)
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
        string messge = Console.ReadLine();
        string cypher = Console.ReadLine();       
        Console.WriteLine(Encode(Encrypt(messge, cypher) + cypher + cypher.Length.ToString()));

    }
}

