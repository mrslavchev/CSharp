using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a method that from a given array of students finds all students whose first 
name is before its last name alphabetically. Use LINQ query operators.*/

class Program
{
    static void Main()
    {
        Student[] myClass = 
        {
               new Student("Pesho", "Topalov"),  
               new Student("Gencho", "Batashki"),
               new Student("Bate", "Kirov"),
               new Student("Pencho", "Qunchev")
        };

        var sortedArray =
            from student in myClass
            where student.FirstName.CompareTo(student.SecondName) == -1
            select student;

        foreach (var student in sortedArray)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.SecondName);
        }
    }
}

