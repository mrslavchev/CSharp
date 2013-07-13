using System;

class Program
{
    static void Main()
    {
        string firstName = "Jane";
        string familyName = "Doe";
        byte age = 30;
        char gender = 'f';
        string idNumber = "120489123C";//considering string for id because in several countries personal ID numbers contain letters too
        int employeeNumber = 27569999;
        Console.WriteLine("First name: {0}\nFamily name: {1}\nAge: {2}\nGender: {3}\nID number: {4}\nUnique employee number: {5}",firstName,familyName,age,gender,idNumber,employeeNumber);

    }
}

