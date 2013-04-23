//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).


using System;

class CorrectInBrackets
{
    static void Main(string[] args)
    {
        string input = "( ( dasd ) ( ( dasd ) ) )";

        int count = 0;

        bool isTrue = true;

        for (int i = 0; i < input.Length; i++)
        {

            if (input[i] == '(')
            {
                count++;
            }

            if (input[i] == ')')
            {
                count--;
            }

            if (count < 0)
            {
                isTrue = false;
            }

        }

        Console.WriteLine(isTrue);

    }
}