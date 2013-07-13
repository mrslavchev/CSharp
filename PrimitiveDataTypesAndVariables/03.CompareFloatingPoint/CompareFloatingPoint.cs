
  using System;

class CompareFloatingPoint
{
    static void Main()
    {
        Console.WriteLine("Let's compare numbers.\nPlease write a number"); 
        string number1 = Console.ReadLine();
        Console.WriteLine("Please write another number");
        string number2 = Console.ReadLine();

        decimal number1dec;
        decimal number2dec;
        bool result;
        if (Decimal.TryParse(number1, out number1dec) && Decimal.TryParse(number2, out number2dec))  
        {
            result = Math.Round(number1dec, 6) == Math.Round(number2dec, 6);  
            Console.WriteLine("Are the two numbers equal? {0}", result);
        }
        else
        {
            Console.WriteLine("Your input is not a number. Please enter a valid number."); 

        }
    }
}

        
       
    


