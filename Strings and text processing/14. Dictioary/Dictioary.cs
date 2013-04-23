﻿﻿using System;
using System.Text.RegularExpressions;

class Dictioary
{
    static void Main()
    {
        string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes"
        };
        string word = "namespace";

        // TODO: Interpolation search
        foreach (string item in dictionary)
        {
            var fragments = Regex.Match(item, "(.*?) - (.*)").Groups;

            if (fragments[1].Value == word)
            {
                Console.WriteLine(fragments[2]);
                return;
            }
        }
    }
}