using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConsoleTest
{
    static void Main(string[] args)
    {
        Student[] students = new Student[6] 
        {
            new Student{FirstName = "John", LastName = "Doe", Age = 13},
            new Student{FirstName = "Mona", LastName = "Dona", Age = 23},
            new Student{FirstName = "Jackie", LastName = "Chan", Age = 23},
            new Student{FirstName = "Alpha", LastName = "Betical", Age = 71},
            new Student{FirstName = "Adams", LastName = "Family", Age = 66},
            new Student{FirstName = "Adams", LastName = "Famila", Age = 66},
        };

        // Task 1 - first name before last
        var sorted =
            from s in students
            where s.FirstName.CompareTo(s.LastName) == -1
            select s;

        Console.WriteLine("First name before last");
        foreach (var item in sorted)
        {
            Console.WriteLine("\t{0} {1}", item.FirstName, item.LastName);
        }

        // Task 2 - age between 18 and 24

        var young =
            from s in students
            where s.Age >= 18 && s.Age <= 24
            select new { s.FirstName, s.LastName };

        Console.WriteLine("Age between 18 and 24");
        foreach (var item in young)
        {
            Console.WriteLine("\t{0} {1}", item.FirstName, item.LastName);
        }

        // Task 3 a) Sort descending by lambda

        var ordered = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);
        Console.WriteLine("Sort descending by lambda");
        foreach (var item in ordered)
        {
            Console.WriteLine("\t{0} {1}", item.FirstName, item.LastName);
        }

        // Task 3 b) Same with LINQ

        var orderedLinq =
            from s in students
            orderby s.FirstName descending, s.LastName descending
            select s;

        Console.WriteLine("Same with LINQ");
        foreach (var item in orderedLinq)
        {
            Console.WriteLine("\t{0} {1}", item.FirstName, item.LastName);
        }
    }
}

