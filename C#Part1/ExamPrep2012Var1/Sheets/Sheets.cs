using System;
using System.Collections.Generic;
/// <summary>
/// We use the fact that the way sheets are cut is the power of two, this way the number of papers
/// needed converted to binary shows all sheets used(1's) and all not used(0's). We make array of strings with
/// corresponding values (A10 is the rightmost bit) and if we have a bit of 0 we print the corresponding sheet.
/// </summary>
class Sheets
{
    public static List<int> CutSheets(int n)
    {
        List<int> output = new List<int>();
        while (n != 0)
        {
            output.Add(n % 2);
            n = n / 2;
        }

        int len = 11 - output.Count;
        for (int i = 0; i < len; i++)
        {
            output.Add(0);
        }

        output.Reverse();
        return output;
    }
    
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> a = CutSheets(n);
        string[] sheets = { "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10" };
        for (int i = 0; i < a.Count; i++ )
        {
            if (a[i] == 0)
            {
                Console.WriteLine(sheets[i]);
            }
        }
    }
}

