using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/*Write a program that reads a string from the console and prints all different
 * letters in the string along with information how many times each letter is found*/
/// <summary>
/// We are reading the string and storing the letters in a dictionary. The key is the letter and 
/// the number of repetitions is the value. We check if a letter(key) is contained in the dict - if not we add it, 
/// if yes, we just increment the value.
/// </summary>
class DifferentLetters
{
    static void Main()
    {
        string text = "This is simple string for counting letters.";
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '.' || text[i] == ' ') 
            {
                continue;
            }
            else
            {
                if (dict.ContainsKey(text[i]))
                {
                    dict[text[i]]++;
                }
                else
                {
                    dict.Add(text[i], 1);
                }
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine("Letter:{0} {1}", item.Key, item.Value);
        }
        
    }
}