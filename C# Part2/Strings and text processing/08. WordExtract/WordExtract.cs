﻿using System;
using System.Text.RegularExpressions;
/*Write a program that extracts from a given text all sentences containing given word.
*/
class WordExtract
{
    /// <summary>
    /// Using regular expressions.
    /// We obtain everything thats "in" and is boredered by spaces, and has anything on the right side up to a period
    /// and anything on it's left side except the period.
    /// </summary>
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string pattern = @"\s*([^\.]*\bin\b.*?\.)";
        MatchCollection sentences = Regex.Matches(text, pattern);
        foreach (var sentence in sentences)
        {
            Console.WriteLine(sentence);
        }
    }
}