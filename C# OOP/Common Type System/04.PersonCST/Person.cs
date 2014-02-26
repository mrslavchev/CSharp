using System;
using System.Text;

class Person
{
    /* The age property is string on purpose - easier to make not specified
     * and we are not performing mathematical operations over it.*/
    private string name;
    private string age;

    public string Name 
    {
        get { return this.name; }
        private set 
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot hold null or empty string.");
            }

            this.name = value;
        }
    }
    public string Age 
    {
        get { return this.age; }
        private set
        {
            if (value == null)
            {
                this.age = "unspecified";
            }
            else
            {
                this.age = value;
            }
        }
    }  
                                             
    public Person(string name, string age)
    {
        this.Name = name;
        this.Age = age;
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

