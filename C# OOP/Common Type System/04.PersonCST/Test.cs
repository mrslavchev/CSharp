using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Create a class Person with two fields – name and age. Age can be left unspecified
 * (may contain null value. Override ToString() to display the information of a 
 * person and if age is not specified – to say so. Write a program to test this functionality.
*/

class Program
{
    static void Main()
    {
        Person onePerson = new Person("Minka");
        Person otherPerson = new Person("Ginka", "35");
        Console.WriteLine(onePerson);
        Console.WriteLine(otherPerson);
    }
}

