using System;
using System.Text;

/// <summary>
/// A marketing firm wants to keep record of its employees. 
/// Each record would have the following characteristics – first name, 
/// family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
/// Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
/// </summary>
class MarketingFirm
{
    //Class
    public class Employee
    {
        //fields
        private string firstName;
        private string familyName;
        private int age;
        private Gender gender;
        private string idNumber;
        private int uniqeEmployeeNo;

        //Constructor
        public Employee(string firstName, string familyName, int age, Gender gender, string idNo, int uniqueEmployeeNo) 
        {
            this.firstName = firstName;
            this.familyName = familyName;
            this.age = age;
            this.gender = gender;
            this.idNumber = idNo;
            this.uniqeEmployeeNo = uniqueEmployeeNo;
        }

        //Method override
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("First name: {0}\n", this.firstName);
            output.AppendFormat("Family name: {0}\n", this.familyName);
            output.AppendFormat("Age: {0}\n", this.age.ToString());
            output.AppendFormat("Gender: {0}\n", this.gender.ToString());
            output.AppendFormat("Id No: {0}\n", this.idNumber);
            output.AppendFormat("Unique employee No: {0}\n", this.uniqeEmployeeNo.ToString());

            return output.ToString();
        }

    }

    static void Main()
    {
        Employee junior = new Employee("John", "Doe", 24, Gender.M, "21BGweb657", 27569999);
        Console.WriteLine(junior);
    }
}

