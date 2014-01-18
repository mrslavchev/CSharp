using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MagicWords
{
    static void Main(string[] args)
    {
        int len = int.Parse(Console.ReadLine());
        SwitchWords(len);
    }

    private static void SwitchWords(int len)
    {
        List<string> words = new List<string>();
        int swapStep = 0;
        for (int i = 0; i < len; i++)
        {
            words.Add(Console.ReadLine());
        }

        string temp = "";
        for (int i = 0; i < words.Count; i++)
        {
            swapStep = words[i].Length % (len + 1);
            temp = words[i];
            words[i] = null;
            words.Insert(swapStep, temp);
            words.Remove(null);
        }

        int max = words.Max(s => s.Length);
        StringBuilder output = new StringBuilder();
        for (int row = 0; row < max; row++)
        {
            for (int col = 0; col < words.Count; col++)
            {
                if (col < words.Count && row < words[col].Length)
                {
                    output.Append(words[col][row]);
                }
                else
                {
                    continue;
                }
            }
        }
        Console.WriteLine(output.ToString());
    }
}

