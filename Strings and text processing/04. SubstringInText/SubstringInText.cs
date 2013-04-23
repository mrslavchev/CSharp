﻿//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//		Example: The target substring is "in". The text is as follows:
﻿

using System;
using System.Text.RegularExpressions;

class SubstringInText
{
    static void Main()
    {
        string str = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substr = "in";

        Console.WriteLine(Regex.Matches(str, substr, RegexOptions.IgnoreCase).Count);
    }
}