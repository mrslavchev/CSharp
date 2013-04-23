using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Student
{
    public Student(string firstName, string secondName)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
    }

    public string FirstName { get; set; }

    public string SecondName { get; set; }
}

