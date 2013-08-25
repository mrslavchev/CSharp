﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/*Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/
/// <summary>
/// We use split method for the string and sort the array, nothing fancy. 
/// </summary>
class SortStrings
{
    static void Main()
    {
        string input = "baba bebe ganka anka tepsia pepsi coca-cola kebabcheta C#";
        string[] words = input.Split(' ');
        Array.Sort(words);
        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }
}