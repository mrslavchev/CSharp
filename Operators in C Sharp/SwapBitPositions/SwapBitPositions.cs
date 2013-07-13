using System;

class ReplacingBits
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of your number is: \n{0}", Convert.ToString(num, 2));
        int p1 = 3;
        int p2 = 24;  //starting positions
        int mask1 = 7 << p1;   //binary represented as 111 
        int mask2 = 7 << p2;   
        int bitStack1 = num & mask1;  //obtaining the bits for both positions
        int bitStack2 = num & mask2;  //obtaining the bits for both positions        
        int change = (num & ~mask1) & ~mask2;    //replacing possitions 3,4,5,24,25,26 with 0
        int newMask1 = (bitStack1 >> p1) << p2;        //moving the numbers to the correct position
        int newMask2 = (bitStack2 >> p2) << p1;
        int finalResult = (change | newMask1) | newMask2;   //placing the new bits into the number
        Console.WriteLine("The result is {0} and it's binary representation is: \n{1}", finalResult, Convert.ToString(finalResult, 2));
    }
}