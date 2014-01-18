using System;
using System.Collections.Generic;
using System.Linq;

// Not done !!
class MovingLetters
{
    static List<char> GetLetters(string[] array)
    {
        List<char> output = new List<char>();
        int max = array.Max(x => x.Length);
        int len = 0;
        for (int i = 0; i < max; i++)
        {
            for (int k = 0; k < array.Length; k++)
            {
                if (k < array[k].Length)
                {
                    len = array[k].Length - 1 - i;
                    if (len < 0)
                    {
                        continue;
                    }
                    output.Add(array[k][len]);
                }
            }
        }
        return output;
    }

    static void MoveChars(List<char> chars)
    {
        int index = 0;
        char c = ' ';
        for (int i = 0; i < chars.Count; i++)
        {
            int len = chars.Count;
            index = ((int)i + chars[i]) % (len + 1);
            Console.WriteLine(index);
            c = chars[i];
            chars.Remove(chars[i]);
            chars.Insert(index + 1, c);
        }
    }
    
    static void Main()
    {
        string words = Console.ReadLine();
        string[] arr = words.Split(' ');
        List<char> list = GetLetters(arr);
        foreach (var item in list)
        {
            Console.Write(item);
        }
        Console.WriteLine();
        MoveChars(list);
        foreach (var item in list)
        {
            Console.Write(item);
        }
        Console.WriteLine();
        // Replace letters 
    }
}

