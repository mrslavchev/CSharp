using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Student firstStudent = new Student("Pesho", "Peshev", "Peshev", 1121, "Sofia, tam", "pesho@abv.bg", "08898898"
            , 3, University.SU, Faculty.FMI, Specialty.Mathematics);
        Console.WriteLine("First student: \n" + firstStudent);

        // Testing the deep clone.
        Student clone = firstStudent.Clone();
        Console.WriteLine(clone);
        Console.WriteLine("If the two students are reffering the same object, output should be \"true\": " 
        + firstStudent.Equals(clone));
        
        // To demonstrate the opposite we make a a simple copy pointing to the same object.
        Student testStudent = firstStudent;
        Console.WriteLine("Demo of shallow copy - {0}", firstStudent.Equals(testStudent));

        Student secondStudent = new Student("Angel", "Atanasov", "Anastasov", 1151);
        Student thirdStudent = new Student("Anastas", "Angelov", "Atanasov", 2315);
        Student fourthStudent = new Student("Nikola", "Kirilov", "Nikolov", 1156);
        Student fifthStudent = new Student("Angel", "Atanasov", "Anastasov", 2151);

        Console.WriteLine("<-----Testing IComparable here ---->");
        Console.WriteLine();

        List<Student> students = new List<Student>();
        students.Add(firstStudent);
        students.Add(secondStudent);
        students.Add(thirdStudent);
        students.Add(fourthStudent);
        students.Add(fifthStudent);

        IEnumerable<Student> query = students.OrderBy(Student => Student.FirstName); 
        foreach (var student in query)
        {
            Console.WriteLine(student); 
        }
    }
}

