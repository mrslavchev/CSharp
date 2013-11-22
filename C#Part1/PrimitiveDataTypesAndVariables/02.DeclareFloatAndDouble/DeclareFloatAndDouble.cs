using System;

/// <summary>
/// Which of the following values can be assigned to a variable of type float 
/// and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
/// </summary>
class DeclareFloatAndDouble
{
    static void Main(string[] args)
    {
        double d1 = 34.567839023;
        float f1 = 12.345f;
        double d2 = 8923.1234857;
        float f2 = 3456.091f;
        Console.WriteLine("Float values are: {0} and {1}.\nDouble values are : {2} and {3}",f1,f2,d1,d2);
    }
}

