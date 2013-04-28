using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Refactor the following examples to produce code with well-named C# identifiers:

class Data
{
    const int MaxCount = 6; // couldn't figure out a context for this, so just left it that way

    public  class UserData
    {
        public void PrintData(bool IsValid)
        {
            string IsValidAsString = IsValid.ToString();
            Console.WriteLine(IsValidAsString);
        }
    }
    public static void CollectInput()
    {
        Data.UserData RandomUser =
          new Data.UserData();
        RandomUser.PrintData(true);
    }
}
    
