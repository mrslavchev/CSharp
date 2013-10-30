using System;
/// <summary>
/// Declare a character variable and assign it with the symbol that has Unicode code 72.
/// Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
/// </summary>

class DeclareChar72
{
    static void Main()
    {
        char uni='\u0048';// by checking with windows calculator we found out, that hex representation of 72 is 48
        Console.WriteLine("The character representation of 72 is: {0}",uni);
    }
}

