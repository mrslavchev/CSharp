//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".


using System;

class ReversedString
{
    static void Main(string[] args)
    {
        string greeting = "Hello";
        char[] letters = greeting.ToCharArray();
        Array.Reverse(letters);
        greeting = new string(letters);
        Console.WriteLine(greeting);
    }
}

