using System;
using System.Text;

class TripleRotationDigits
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input.Length == 1 )
        {
            Console.WriteLine(int.Parse(input));
        }
        else if (input.Length == 2)
        {
            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            string s = new string(temp);
            Console.WriteLine(int.Parse(s));
        }
        else if (input.Length > 2)
        {
            StringBuilder output = new StringBuilder();
            for (int i = input.Length -1; i >= input.Length - 3; i--)
            {
                if (input[i] == '0')
                {
                    continue;
                }
                else
                {
                    output.Insert(0, input[i]);
                }
            }

            if (input.Length != 3)
            {
                output.Append(input.Substring(0, input.Length - 3));
            }

            Console.WriteLine(output.ToString());
        }
    }
}