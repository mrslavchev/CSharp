using System;

class StringHelloWorld
{
    static void Main()
    {
        string greeting = "Hello";
        string recipient = "world";
        object sum = (greeting + " " + recipient);
        string sum2 = (string)sum;
        Console.WriteLine("{0}\n{1}",sum,sum2);
    }
}

