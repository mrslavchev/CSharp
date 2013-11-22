using System;
using System.Text;

class AstroDigits
{
    public static string SumDigits(string str)
    {
        StringBuilder temp = new StringBuilder();
        while (str.Length > 1)
        {
            for (int i = 0; i < str.Length; i++)
            {
                int a = int.Parse(str[i].ToString());
                int b = int.Parse(str[i + 1].ToString());
                if ((str[i] != '-') || (str[i] != '.'))
                {
                    //Console.WriteLine('1' + '2');
                    temp.Append(a + b);
                    if (i == str.Length -1)
                    {
                        str = temp.ToString();
                    } 

                    temp.Clear();
                }
                else
                {
                    continue;
                }
            }
        }

        return str;
    }
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(SumDigits(input));     
    }
}

