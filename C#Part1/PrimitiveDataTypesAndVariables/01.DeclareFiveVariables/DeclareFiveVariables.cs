using System;

/// <summary>
/// Declare five variables choosing for each of them the most appropriate of the types 
/// byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
/// 52130, -115, 4825932, 97, -10000.
/// </summary>
/// 
class DeclareFiveVariables
{
    static void Main()
    {
        ushort value1 = 52130;
        sbyte value2 = -115;
        int value3 = 4825932;
        byte value4 = 97;
        short value5 = -10000;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", value1, value2, value3, value4, value5);
    }
}

