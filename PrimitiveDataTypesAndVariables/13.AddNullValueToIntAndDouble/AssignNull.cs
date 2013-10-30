using System;

/// <summary>
/// Create a program that assigns null values to an integer and to double variables. 
/// Try to print them on the console, try to add some values or the null literal to them and see the result.
/// </summary>
class AssignNull
{
    static void Main(string[] args)
    {
        int? number = null;
        double? number2 = null;
        //number = 20;
        Console.WriteLine("int {0} ", number); // null can not be printed since it means no value
        //Console.WriteLine("int {0} ", number.Value); // this throws an exception because most methods do so when null is passed
        Console.WriteLine("double {0}", number2);
    }
}

