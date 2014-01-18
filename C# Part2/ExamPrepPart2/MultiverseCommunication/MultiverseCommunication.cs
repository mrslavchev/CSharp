using System;

class MultiverseCommunication
{
    public static void Main(string[] args)
    {
        string[] digits = new string[] { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA", };
        string input = Console.ReadLine();
        long result = 0;
        int power = 0;
        for (int i = input.Length - 3; i >= 0; i -= 3)
        {
            string digit = input.Substring(i, 3);
            long value = Array.IndexOf(digits, digit);
            result += value * (long)Math.Pow(13, power);
            power++;
        }
        Console.WriteLine(result);
    }
}

