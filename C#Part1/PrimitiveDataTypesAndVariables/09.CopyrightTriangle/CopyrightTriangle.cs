using System;

using System;
using System.Text; 

/// <summary>
/// Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
/// Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.
/// </summary>
class CopyrightTriangle
{
    /// <summary>
    /// A bit of cursor positionning magic, the commented part is the same as using the loops but 
    /// just drawing the symbols on specific positions. It produces the same result. I don't think I got to the bottom of it
    /// and come up with a formula that would work for triangle with more rows, so it's a bit of "magic lines" code.
    /// Basically we draw the left side of the triangle with the outer for loop, we draw the right side using inner spacing = to
    /// the row + outerspacing * 2. And we draw the base using another loop and inner spacing incrementing by 2.
    /// </summary>
    static void Main()
    {
        char copyRight = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode;
        //row 1
        /*Console.SetCursorPosition(3, 0);
        System.Console.Write(copyRight);
        //row 2
        Console.SetCursorPosition(2, 1);
        System.Console.Write(copyRight);
        Console.CursorLeft = 4;
        System.Console.Write(copyRight);
        // row 3
        Console.SetCursorPosition(1, 2);
        System.Console.Write(copyRight);
        Console.CursorLeft = 5;
        System.Console.Write(copyRight);
        //row 4
        Console.SetCursorPosition(0, 3);
        System.Console.Write(copyRight);
        Console.CursorLeft = 2;
        System.Console.Write(copyRight);
        Console.CursorLeft = 4;
        System.Console.Write(copyRight);
        Console.CursorLeft = 6;
        System.Console.WriteLine(copyRight);*/
        int outerSpacing = 3;
        int innerSpacing = 0;
        for (int row = 0; row < 4; row++)
        {
            Console.SetCursorPosition(outerSpacing, row);
            System.Console.Write(copyRight);
            if (row == 1|| row == 2)
            {
                Console.SetCursorPosition((outerSpacing + row * 2), row);
                System.Console.Write(copyRight);
            }
            if (row == 3)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition(innerSpacing, row);
                    System.Console.Write(copyRight);
                    innerSpacing += 2;
                }
            }
            outerSpacing--;
            
        }
        System.Console.WriteLine();
    }
}
