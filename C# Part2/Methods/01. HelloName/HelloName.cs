using System;
//Write a method that asks the user for his name and prints “Hello, <name>” 
//(for example, “Hello, Peter!”). Write a program to test this method.

    public class HelloName
    {
        public static void GreetUser() 
        {
            Console.WriteLine("Please write down your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);

        }
        static void Main()
        {
            GreetUser();
        }
    }
