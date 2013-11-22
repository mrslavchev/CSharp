//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).
using System;
using System.Text.RegularExpressions;
class CorrectInBrackets
{
    /// <summary>
    /// We use the bracket counter to follow what occurances of brackets we have.
    /// We increment it on ( and decrease it on ).
    /// Keeping in mind at the end it has to be 0, cuz the number of ('s has to be = to )'s
    /// There's only one case wheere brackets count could be negative, 
    /// and in it brackets are positionned incorrect, so we break it there.
    /// This is the case where we have ) without corresponding ( to it.
    /// The oposite could't be caught on the fly since we have to check the whole string for the corresponding )
    /// </summary>
    static void Main()
    {
        string input = "((a+b)/(5-d))";
        Console.WriteLine(input);
        char openBracket = '(';
        char closeBracket = ')';
        int bracketsCounter = 0;
        string correct = "Brackets are positionned correct";
        string inCorrect = "Brackets are not positionned correct";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == openBracket)
            {
                bracketsCounter++;
            }
            if (input[i] == closeBracket)
            {
                bracketsCounter--;
                if (bracketsCounter < 0)
                {
                    Console.WriteLine(inCorrect);
                    return;
                }
            }
        }

        if (bracketsCounter != 0)
        {
            Console.WriteLine(inCorrect);
        }
        else
        {
            Console.WriteLine(correct);
        }
    }
}