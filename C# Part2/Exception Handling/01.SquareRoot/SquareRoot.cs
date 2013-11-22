﻿using System;
/*Write a program that reads an integer number and calculates and prints its square root. 
 * If the number is invalid or negative, print "Invalid number". 
 * In all cases finally print "Good bye". Use try-catch-finally*/
class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.WriteLine("PLease write positive integer:");
            int inputNum = int.Parse(Console.ReadLine());
            if (inputNum < 0)
            {
                throw new ArgumentException("Invalid input");
            }
            double sqRt = Math.Sqrt(inputNum);
            Console.WriteLine(sqRt);
        }
        catch (System.FormatException)
        {

            Console.Error.WriteLine("Invalid number");
        }
        catch (System.ArgumentException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        catch (System.OverflowException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}