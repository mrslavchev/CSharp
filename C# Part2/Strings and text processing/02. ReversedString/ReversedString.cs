//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".
using System;
using System.Text;
class ReversedString
{
    /// <summary>
    /// We can do this with char array too, but it's lame.
    /// </summary>
    static void Main()
    {
        string input = "new sample string";
        StringBuilder reversed = new StringBuilder();
        for (int i = input.Length-1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        Console.WriteLine(reversed.ToString());
    }
}

