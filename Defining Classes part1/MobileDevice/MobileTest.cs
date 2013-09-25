using System;

/// <summary>
/// Tests the GSM/Battery and Display clsses, by requirements. 
/// </summary>
public class MobileTest
{
    public static void PerformTest()
    {
        GSM[] mobiles = 
    {
        new GSM("Huavei", "Samsung"), 
        new GSM("Xperia", "Sony", 1000, "Kiro"),
        new GSM("Windows phone", "Microsoft", 5, "Bill")
    };

        foreach (var phone in mobiles)
        {
            Console.WriteLine(phone);
        }

        Console.WriteLine(GSM.IPhone4S);
    }
}

