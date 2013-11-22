using System;

/// <summary>
/// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true
/// </summary>
class ThirdIsSeven
{
    static void Main()
    {
        int num = 1234765;
        int num2 = (num/100);
        int num3 = (num2 % 10);
        bool result = (num3 == 7);
        Console.WriteLine("Is the third digit of {0} a seven? {1}",num,result);
    }
}

