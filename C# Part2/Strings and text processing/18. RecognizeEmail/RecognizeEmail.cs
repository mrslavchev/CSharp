using System;
using System.Text.RegularExpressions;
/*Write a program for extracting all email addresses from given text. 
 * All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails*/
class RecognizeEmail
{
    static void Main()
    {
        string text = "This is a simple text where we are going to put few emails like svirka@duduk.com, mara@duduk.net and pesho@gosho.bg, pena.byrzata@sharo.baro.com, gosho@pochivka.com";
        string pattern = @"([\w-\.]+)@((?:[\w]+\.)+)([a-zA-Z]{2,4})";
        MatchCollection mails = Regex.Matches(text, pattern);
        foreach (var item in mails)
        {
            Console.WriteLine(item);
        }
    }
}