using System;
/*Write a method that checks if the element at given position
 * in given array of integers is bigger than its two neighbors (when such exist).
*/
public class BiggerThanNeighbours
{
    /// <summary>
    /// Checks if given index has neighbours or is on the borders
    /// </summary>
    /// <param name="array">Takes int array as fiest param</param>
    /// <param name="index">Takes index to check as second param</param>
    /// <returns>bool value </returns>
     static bool HasNeighbors(int[] array, int index ) 
    {
        if (index > 0 && index < array.Length -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Check the neighbours for being bigger or not
    /// </summary>
    /// <param name="array"></param>
    /// <param name="index"></param>
    /// <returns></returns>
    public static bool CompareToNeighbours(int[] array, int index) 
    {
        if (HasNeighbors(array, index))
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        int[] myArr = {1, 2, 3, 4, 1, 3, 5 };
        int testInd = 0;
        Console.WriteLine("Is {0} bigger than it's neighbours?", myArr[testInd]);
        Console.WriteLine(CompareToNeighbours(myArr, testInd));
    }
}
