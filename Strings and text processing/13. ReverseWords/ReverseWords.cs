﻿﻿using System;
using System.Text.RegularExpressions;
using System.Text;
/*Write a program that reverses the words in given sentence.
*/
/// <summary>
/// Using regex we obtain the words, store them in matching collection
/// and append them vice-versa to a stringbuilder.
/// Hadn't been able to handle the exclemation mark. 
/// </summary>
class Program
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        string pattern = @"\w+[^\s!]{1,}";
        MatchCollection words = Regex.Matches(text, pattern);
        StringBuilder output = new StringBuilder();
        for (int i = words.Count-1; i >= 0; i--)
        {
            output.AppendFormat("{0} ", words[i]);
        }

        Console.WriteLine(output.ToString().TrimEnd() + '!'); //this is ugly, don't do it !!! :) 
    }
}