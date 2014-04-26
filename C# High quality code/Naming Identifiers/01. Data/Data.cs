using System;

// Refactor the following examples to produce code with well-named C# identifiers.
public class Data
{
    public static void CollectInput()
    {
        Data.UserData randomUser =
          new Data.UserData();
        randomUser.PrintData(true);
    }

    public class UserData
    {
        public void PrintData(bool isValid)
        {
            string isValidAsString = isValid.ToString();
            Console.WriteLine(isValidAsString);
        }
    }
}