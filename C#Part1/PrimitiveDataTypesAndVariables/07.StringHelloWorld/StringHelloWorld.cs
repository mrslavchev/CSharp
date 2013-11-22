using System;
/// <summary>
/// Declare two string variables and assign them with “Hello” and “World”. 
/// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
/// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
/// </summary>

class StringHelloWorld
{
    static void Main()
    {
        string greeting = "Hello";
        string recipient = "world";
        object concatObj = (greeting + " " + recipient);
        string concatStr = (string)concatObj;
        Console.WriteLine("{0}\n{1}",concatObj,concatStr);
    }
}

