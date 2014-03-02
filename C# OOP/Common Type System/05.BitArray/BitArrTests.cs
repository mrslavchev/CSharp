using System;

class BitArrTests
{
    static void Main()
    {
        BitArray bitArr = new BitArray(70);

        Console.WriteLine("Count: " + bitArr.Count);
        Console.WriteLine("Capacity: " + bitArr.Capacity);

        bitArr[1] = true;
        Console.WriteLine(bitArr[1]);
        bitArr[1] = false;
        Console.WriteLine(bitArr[1]);
        Console.WriteLine();
        
        bitArr[0] = true;
        bitArr[bitArr.Count - 1] = true;
        Console.WriteLine(bitArr);
        
    }
}