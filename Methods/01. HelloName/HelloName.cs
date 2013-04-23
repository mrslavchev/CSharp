using System;



namespace PrintNameClass
{
    class HelloName
    {
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);

        }

        static bool ValidateName(string name)
        {
            bool result = false;

            for (int charPosition = 0; charPosition < name.Length; charPosition++)
            {
                result = Char.IsLetter(name, charPosition);
            }
            return result;
        }


        static void Main()
        {
            //Write a method that asks the user for his name and prints “Hello, <name>”
            //    (for example, “Hello, Peter!”). Write a program to test this method.

            Console.Write("Please enter your name: ");

            string name = Console.ReadLine();

            if (ValidateName(name))
            {
                PrintName(name);
            }
            else
            {
                Console.WriteLine("You have entered an invalid name!");
            }

        }
    }
}