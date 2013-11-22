﻿using System;
using System.Collections.Generic;
/*Write a program that reads a string from the console and lists all different words 
 * in the string along with information how many times each word is found*/
/// <summary>
/// Same approach as the previous task.
/// We store the strings in an array and put them in dictionary containing the string(key) and the number od repetitions(value).
/// The challenge here was to skip adding empty spaces after the period. Did it the lame way :)
/// </summary>
class DifferentStrings
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days";
        string[] words = text.Split('.', ' ');
        Dictionary<string, int> dict = new Dictionary<string, int>(); 
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == "")
            {
                continue;
            }
            else
            {
                if (dict.ContainsKey(words[i]))
                {
                    dict[words[i]]++;
                }
                else
                {
                    dict.Add(words[i], 1);
                }
            }
        }

        foreach (var pair in dict)
        {
            Console.WriteLine("Word: \"{0}\" - {1} times", pair.Key, pair.Value);
        }
    }
}