﻿using System;
using System.Text;
/*Write a program that converts a string to a sequence of C# Unicode character literals.
 * Use format strings. Sample input:
*/
class UnicodeChars
{
    static void Main()
    {
        string input = "Hello C#!";
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            output.AppendFormat("\\u{0:x4}", (int)input[i]);
        }
        Console.WriteLine("{0}\n{1}", input, output.ToString());
    }

}