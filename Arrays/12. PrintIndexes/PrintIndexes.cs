//Write a program that creates an array containing
//all letters from the alphabet (A-Z). Read a word
//from the console and print the index of each of its letters in the array.
//

using System;
/// <summary>
/// We fill the array of chars
/// than compare every char of the word with all chars in the array
/// if we find a match we print the char and it's index in the array.
/// </summary>
class LetterIndex
{
    static void Main()
    {
        char[] alphabet = new char[26];
        char letter = 'a';
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = letter;
            letter++;
        }

        Console.WriteLine("Enter a word:");
        string inputWord = Console.ReadLine().ToLower(); //we exclude the upper casse here
        for (int let = 0; let < inputWord.Length; let++)
        {
            for (int index = 0; index < alphabet.Length; index++)
            {
                if (inputWord[let] == alphabet[index])
                {
                    Console.WriteLine("Leter {0} has index: {1}", inputWord[let], index);
                    break;
                }
            }
        }
    }
}