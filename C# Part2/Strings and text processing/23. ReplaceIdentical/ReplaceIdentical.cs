﻿using System;
using System.Text.RegularExpressions;

class ReplaceIdentical
{
    static void Main()
    {
        string text = "aaaabbbbbssssssjjjjjjllllddddddaaaddddddduuuuuu";

        Console.WriteLine(Regex.Replace(text, @"(\w)\1+", "$1")); // using back reference 
    }
}