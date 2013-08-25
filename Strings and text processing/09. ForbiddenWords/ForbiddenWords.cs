﻿using System;
using System.Text.RegularExpressions;
/*We are given a string containing a list of forbidden words and a text containing some of these words.
 * Write a program that replaces the forbidden words with asterisks*/
class ForbiddenWords
{
    /// <summary>
    /// We split the list string and trim all its members, than replace them with their length in asterix
    /// </summary>
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string words = "PHP, CLR, Microsoft";
        string[] wordCollection = words.Split(',');
        for (int i = 0; i < wordCollection.Length; i++)
        {
            wordCollection[i] = wordCollection[i].Trim();
            text = Regex.Replace(text, wordCollection[i], "".PadRight(wordCollection[i].Length, '*'));
        }

        Console.WriteLine(text);
    }
}