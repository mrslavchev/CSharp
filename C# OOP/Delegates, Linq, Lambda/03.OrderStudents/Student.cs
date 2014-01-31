using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*No checks for invalid data is applied 
 * since I am only using this class for tests*/
public class Student
{
    private string firstName;
    private string lastName;
    private int age;

    public string FirstName 
    {
        get { return this.firstName; }
        set { firstName = value; }
    }

    public string LastName 
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }

    public int Age
    {
        get {return this.age;}
        set { this.age = value; }
    }

    public Student(string fName, string lName, int age)
    {
        this.FirstName = fName;
        this.LastName = lName;
        this.Age = age;
    }
    public Student()
    { }
}

