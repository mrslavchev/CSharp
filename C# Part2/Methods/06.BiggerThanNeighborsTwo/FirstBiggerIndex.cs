using System;
/*Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise.
*/

class FirstBiggerIndex
{
    static int ReturnFirstIndex(int[] array) 
    {
        int output = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (BiggerThanNeighbours.CompareToNeighbours(array, i))
            {
                output = i;
                break;
            }
            else
            {
                output = -1;
            }
        }

        return output;
    }

    static void Main()
    {
        int[] arrayofNumbers = { 2, 3, 5, 3, 1, 2 };
        Console.WriteLine("Which is the first index bigger than it's neighbors?");
        Console.WriteLine(ReturnFirstIndex(arrayofNumbers));
    }
}