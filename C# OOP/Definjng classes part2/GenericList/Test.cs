using System;

class Test
{
    static void Main()
    {
        GenericList<int> nums = new GenericList<int>();
        nums.Add(1);
        nums.Add(2);
        nums.Add(1);
        nums.Add(11);
        nums.Add(1);
        nums.Add(-11);
        nums.RemoveAt(2);
        nums.InsertAt(4, 22);
        Console.WriteLine(nums.IndexOf(22));  
        Console.WriteLine(GenericList<int>.Min(nums));
        Console.WriteLine(GenericList<int>.Max(nums));
        nums.Clear();
        Console.WriteLine(nums.Count);
    }
}