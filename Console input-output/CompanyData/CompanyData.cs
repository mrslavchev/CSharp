using System;

/// <summary>
/// A company has name, address, phone number, fax number, web site and manager. 
/// The manager has first name, last name, age and a phone number. 
/// Write a program that reads the information about a company and its manager and prints them on the console.
/// </summary>
class CompanyData
{
    static void Main()
    {
        Console.WriteLine("Please write down company name:");
        string name=(Console.ReadLine());
        Console.WriteLine("Please write down company address:");
        string address = (Console.ReadLine());
        Console.WriteLine("Please write down company phone number:");
        int phone = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write company fax number:");
        int fax =int.Parse (Console.ReadLine());
        Console.WriteLine("Please write down company web site:");
        string site = (Console.ReadLine());
        Console.WriteLine("Please write down the first name of the company manager:");
        string ceoFName = (Console.ReadLine());
        Console.WriteLine("Please write down the last name of the company manager:");
        string ceoLName = (Console.ReadLine());
        Console.WriteLine("Please write down the age of the company manager:");
        byte age =byte.Parse(Console.ReadLine());
        Console.WriteLine("Please write down the phone number of the company manager:");
        string ceoPhone = (Console.ReadLine());
        Console.WriteLine("\nCompany name: {0}\nAddress: {1}\nPhone number: {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6}\nAge: {7}\nPhone: {8}",name,address,phone,fax,site,ceoFName,ceoLName,age,ceoPhone);
    }
}

