using System;
using System.Text;

class WeAllLoveBits
{
    public static uint ReverseBitPosition(uint input) 
    {
        string binary = Convert.ToString(input, 2);
        StringBuilder reversed = new StringBuilder();
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            reversed.Append(binary[i]);
        }

        uint result = Convert.ToUInt32(reversed.ToString(), 2);
        return result;
    }
    //inverted binary converter
    public static uint SwitchBits(uint input) 
    {
        string binary = Convert.ToString(input, 2);
        uint decRepresent = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - i - 1] == '1')
            {
                continue;
            }
            else
            {
                decRepresent += (uint)Math.Pow(2, i);
            }
        }

        return decRepresent;
    }

    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        uint[] nums = new uint[n];
        for (int i = 0; i < n; i++)
        {
            uint p = uint.Parse(Console.ReadLine());
            uint tildaP = SwitchBits(p);
            uint ddP = ReverseBitPosition(p);
            nums[i] = (p ^ tildaP) & ddP;
        }

        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
        
    }
}

