using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{
    public string Name { get; private set; }
    public string Age { get; private set; }  //decided to make the age string its easier to make it unspecified
                                             // + we habe none math operations on it 
    public Person(string name, string age)
    {
        if (name == null || name.Length < 2)
        {
            throw new ArgumentException("Invalid name");
        }
        else
        {
            this.Name = name;
        }

        if (age != null)
        {
            this.Age = age;
        }
        else
        {
            this.Age = "unspecified";
        }
    }
    public Person(string name): this (name, null)
    { 
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.AppendLine("Name: " + this.Name);
        output.AppendLine("Age: " + this.Age);
        return output.ToString();
    }
}

