using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a LINQ query that finds the first name and 
last name of all students with age between 18 and 24.*/

class Program
{
    static void Main()
    {
        Student[] myClass = 
        {
               new Student("Pesho", "Topalov", 89),  
               new Student("Gencho", "Batashki", 45),
               new Student("Bate", "Kirov", 11),
               new Student("Pencho", "Qunchev", 22)
        };

        var sortedClass =
            from student in myClass
            where student.Age >= 18 && student.Age <= 24
            select student;

        foreach (var student in sortedClass)
        {
            Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
        }
    }
}

