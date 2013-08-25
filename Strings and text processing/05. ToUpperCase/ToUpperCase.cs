//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and 
//</upcase> to uppercase. The tags cannot be nested.

﻿using System;
using System.Text.RegularExpressions;
/// <summary>
/// We find a match <upcase>(some text here)</upcase> 
/// and we replace it with the value in the paranthesis, to uppercase.
/// The value is returned by the group property of the Regex.Match()
/// </summary>
class ToUpperCase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string pattern = "<upcase>(.*?)</upcase>";
        Console.WriteLine(Regex.Replace(text, pattern, m => m.Groups[1].Value.ToUpper()));
        
    }
}