using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class SBSubstring
{
    public static StringBuilder Substring(this StringBuilder input, int start, int length)
    {
        StringBuilder Substring = new StringBuilder();
        if (start + length > input.Length)
        {
            throw new ArgumentException();
        }

        int ending = start + length;

        for (int i = start; i < ending; i++)
        {
            Substring.Append(input[i]);
        }

        return Substring;
    }
}

