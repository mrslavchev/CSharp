using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        List<int> output = new List<int>();
        int tempNum = 0;
        int reminder = 0;
        if (input.Length == 1)
        {
            if (input[0] == '6')
            {
                output.Add(0);
                output.Add(1);
            }
            else
            {
                tempNum = int.Parse(input[0].ToString());
                output.Add(++tempNum);
            }
        }
        else if (input.Length == 2)
        {
            if (input[1] == '6')
            {
                output.Add(0);
                if (input[0] == '6')
                {
                    output.Add(0);
                    output.Add(1);
                }
                else
                {
                    tempNum = int.Parse(input[0].ToString());
                    output.Add(++tempNum);
                }
            }
            else
            {
                tempNum = int.Parse(input[1].ToString());
                output.Add(++tempNum);
                tempNum = int.Parse(input[0].ToString());
                output.Add(tempNum);
            }
        }
        else // if length is 3
        {
            if (input[2] == '6')
            {
                output.Add(0);
                if (input[1] == '6')
                {
                    output.Add(0);
                    if (input[0] == '6')
                    {
                        output.Add(0);
                        output.Add(1);
                    }
                    else
                    {
                        tempNum = int.Parse(input[0].ToString());
                        output.Add(++tempNum);
                    }
                }
                else
                {
                    tempNum = int.Parse(input[1].ToString());
                    output.Add(++tempNum);
                    tempNum = int.Parse(input[0].ToString());
                    output.Add(tempNum);
                }
            }
            else
            {
                tempNum = int.Parse(input[2].ToString());
                output.Add(++tempNum);
                tempNum = int.Parse(input[1].ToString());
                output.Add(tempNum);
                tempNum = int.Parse(input[0].ToString());
                output.Add(tempNum);
            }
        }

        output.Reverse();

        foreach (var item in output)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}

