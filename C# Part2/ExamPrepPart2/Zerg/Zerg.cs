using System;

// Copy-paste the solution from MultiverseCommunication, we onlu change the array, the base of the numeral system and the 
// length of the substring.
class MultiverseCommunication
{
    public static void Main(string[] args)
    {
        string[] digits = new string[] { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };
        string input = Console.ReadLine();
        long result = 0;
        int power = 0;
        for (int i = input.Length - 4; i >= 0; i -= 4)
        {
            string digit = input.Substring(i, 4);
            long value = Array.IndexOf(digits, digit);
            result += value * (long)Math.Pow(15, power);
            power++;
        }
        Console.WriteLine(result);
    }
}

