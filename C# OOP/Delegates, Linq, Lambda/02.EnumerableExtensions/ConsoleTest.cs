using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConsoleTest
{
    static void Main(string[] args)
    {
        float[] nums = new float[5] { 1.1f, 2.2f, 33.3f, 4.4f, 555.5f };
        Console.WriteLine(nums.Sum());
        Console.WriteLine(nums.Product());
        Console.WriteLine(nums.Avarage());
        Console.WriteLine(nums.Min());
        Console.WriteLine(nums.Max());
    }
}

