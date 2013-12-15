using System;
using System.Text;
/* Write a program that finds in given array of
   integers a sequence of given sum S (if present).
   Example:      {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5} */

/// <summary>
/// Use second loop to iterate the subset current - end
/// We compare the sum to s and if we find a match we break
/// If not we print there's no such sum
/// </summary>
class SequenceByGivenSum
{
    static void Main()
    {
        Console.WriteLine("Enter the sum which sequence you want to find");
        int s = int.Parse(Console.ReadLine());
        int[] randomArray = { 4, 3, 1, 4, 2, 5, 8 };
        string sequence = "";
        StringBuilder sequenceBuild = new StringBuilder();
        for (int i = 0; i < randomArray.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < randomArray.Length; j++)
            {
                sum = sum + randomArray[j];
                sequenceBuild.AppendFormat("{0}, ", randomArray[j]);
                if (sum == s)
                {
                    sequence = sequenceBuild.ToString();
                    Console.WriteLine("This sequence has the sum of {0} : {1}", s, sequence);
                    return;
                }
                else if (sum > s)
                {
                    sequenceBuild.Clear();
                    sum = 0;
                    break;
                }              
                else if ((sum < s) && (j == randomArray.Length -1))
                {
                    Console.WriteLine("Sequence not present");
                    return;
                }
            }
        }
    }
}