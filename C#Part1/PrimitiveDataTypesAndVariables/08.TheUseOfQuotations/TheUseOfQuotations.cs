using System;
/// <summary>
/// Declare two string variables and assign them with following value:
///	Do the above in two different ways: with and without using quoted strings.
/// </summary>

class TheUseOfQuotations
{
    static void Main()
    {
        string a = "The \"use\" of quotations causes difficulties.";
        string b = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("{0}\n{1}", a,b);
    }

}
