using System;
/*Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".
*/
class LastDigit
{
    static string PrintLastDigit(string input ) 
    {
        switch (input[input.Length-1])
        {
            case '1': return "One";
            case '2': return "Two";
            case '3': return "Three";
            case '4': return "Four";
            case '5': return "Five";
            case '6': return "Six";
            case '7': return "Seven";
            case '8': return "Eight";
            case '9': return "Nine";
            case '0': return "Zero";
            default: return "Not a digit";
        }
    }
    /// <summary>
    /// Test the program 
    /// </summary>
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(PrintLastDigit(i.ToString()));
        }

        Console.WriteLine(PrintLastDigit("r"));
    }
}