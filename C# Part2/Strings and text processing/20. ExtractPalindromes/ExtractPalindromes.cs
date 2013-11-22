using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
/*Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
*/
/// <summary>
/// We can do it with regex, but it's not efficent + the regular expression itself will be hell of a long one. 
/// My approach is a bit more writing but way simpler. We split the words and store them in string collection, 
/// we check if they are palyndromes by converting them to char array. The algorythm is - to check if the array is balanced - e.g.
/// each member at position i up to length/2 has to be == to member at postition length-1-i.
/// </summary>
class Program
{
    /// <summary>
    /// Checks whether string is a palyndrome or not. Splits the string to array of chars and checks if it's balanced. 
    /// </summary>
    /// <param name="word">string as first parameter</param>
    /// <returns>Bool</returns>
    static bool IsPalyndrome(string word) 
    {
        char[] letters = word.ToCharArray();
        bool output = false;
        for (int i = 0; i < letters.Length/2; i++)
        {
            if (letters[i] == letters[letters.Length - 1 - i])
            {
                output = true;
            }
            else
            {
                output = false;
            }
        }

        return output;
    }

    static void Main() 
    {
        string text = "This a simple text from which we wil extract some palindromes like abba, exe, axa, hhhaahhh, and asdsa";
        string pattern = @"\b\w+\b";
        MatchCollection words = Regex.Matches(text, pattern);
        List<string> wordsAsStr = new List<string>();
        foreach (var word in words)
        {
            wordsAsStr.Add(word.ToString()); // I didn't found out a more clever way to convert this, I'm open for suggestions
        }

        foreach (var str in wordsAsStr)
        {
            if (IsPalyndrome(str))
            {
                Console.WriteLine(str);
            }
        }
    }
}