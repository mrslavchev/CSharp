using System;
/*Write a method GetMax() with two parameters that returns the bigger of two integers.
 * Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
*/
class GetMaxNumb
{
    static int GetMax(int a, int b) 
    {
        if (a > b)
        {
            return a;
        }

        else
        {
            return b;
        }
    }

    static void Main() 
    {
        int firstNum = 2;
        int secondNum = 100;
        int thirdNum = -1000;
        Console.WriteLine(GetMax(GetMax(firstNum, secondNum), thirdNum));
    }
}