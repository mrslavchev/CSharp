using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Student firstStudent = new Student("Pesho", "Peshev", "Peshev", 1121, "Sofia, tam", "pesho@abv.bg", "08898898" //instance ot student
            , 3, University.SU, Faculty.FMI, Specialty.Mathematics);
        Console.WriteLine("First student: \n" + firstStudent);
        Student clone = firstStudent.Clone();
        Console.WriteLine(clone); // deep clonening 
        Console.WriteLine("If the two students are the same output should be \"true\": " 
        + firstStudent.Equals(clone));

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

        IEnumerable<Student> query = students.OrderBy(Student => Student.FirstName); //using lambda function ot sort students by name
        foreach (var student in query)
        {
            Console.WriteLine(student); 
        }
    }
}

