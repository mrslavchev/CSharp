using System;

public class CallHistoryTest
{
    /// <summary>
    /// This is a test class for the call history, contains all scenarios to be tested.
    /// 
    /// </summary>
    public static void PerformTest()
    {
        GSM nicksPhone = new GSM("GalaxyS4", "Samsung", 1200, "Nick");
        nicksPhone.AddCall("01.02.2013", 0897303030, 200);
        nicksPhone.AddCall("02.02.2013", 0897303030, 50);
        nicksPhone.AddCall("03.02.2013", 0897303030, 250);
        nicksPhone.AddCall("04.02.2013", 0897303030, 15);
        nicksPhone.AddCall("05.02.2013", 0897303030, 230);
        foreach (var call in nicksPhone.CallHistory)
        {
            Console.WriteLine(call);
        }

        Console.WriteLine("Total price is: {0} leva", nicksPhone.CalculatePrice());
        Call longest = nicksPhone.FindLongestCall();
        Console.WriteLine("The longest call is: \n{0}", longest);
        nicksPhone.RemoveCall(longest);
        Console.WriteLine("Price after removal is: {0} leva", nicksPhone.CalculatePrice());
        nicksPhone.ClearCallHistory();
        Console.WriteLine("Clearing history...");
        if (nicksPhone.CallHistory.Count == 0)
        {
            Console.WriteLine("No records found in call history");
        }
        else
        {
            throw new ArgumentException();
        }
    }
}
