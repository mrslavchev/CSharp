﻿using System;
using System.Collections.Generic;
/*Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]*/
/// <summary>
/// Since we have to make a dictionary I don't see easier way, 
/// than using a dictionary in C#.
/// </summary>
class Dictioary
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            {".NET", "platform for applications from Microsoft"},
            {"CLR", "managed execution environment for .NET"},
            {"namespace", "hierarchical organization of classes"}
        };
        Console.WriteLine("Type one of the following words to see its meaning:\n.NET\nCLR\nnamespace");
        string input = Console.ReadLine();
        Console.WriteLine(dict[input]);
    }
}