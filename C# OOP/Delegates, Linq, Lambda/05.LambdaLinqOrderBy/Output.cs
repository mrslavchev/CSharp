using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Using the extension methods OrderBy() and ThenBy() with lambda expressions
sort the students by first name and last name in descending order. Rewrite the same with LINQ.*/


public class Output
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

        //var sortedClass = myClass.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName); 
        //uncomment the above and commend the below to test the lambda way
        var sortedClass =
           from student in myClass
           orderby student.FirstName descending, student.LastName descending //LINQ
           select student;

        foreach (var student in sortedClass)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }
}   

