//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//		Example: The target substring is "in". The text is as follows:
﻿
using System;
using System.Text.RegularExpressions;

class SubstringInText
{
    /// <summary>
    /// We are using regular expressions and the option ignorecase.
    /// Mathes returns collection of all found mathes, we print it's count.
    /// </summary>
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string pattern = "in";
        Console.WriteLine(Regex.Matches(text, pattern, RegexOptions.IgnoreCase).Count);
    }
}