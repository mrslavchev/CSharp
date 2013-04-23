﻿using System;
using System.Text.RegularExpressions;

class ReplaceIdentical
{
    static void Main()
    {
        string str = "aaaaabbbbbcdddeeeedssaa";

        Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
    }
}