using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Define a class Student, which contains data  about a student – three names, 
 * SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use  enumeration for the specialties, 
 * universities and faculties. Override standard methods, inherited by  System.Object – Equals(), ToString(), 
 * GetHashCode() and operators == and !=.
Add implementations of the ICloneable interface. The Clone() method should copy all the object's fields into a new object of type Student.
 * Implement the  IComparable<Student> interface to compare students by names (as first criteria,
 * in lexicographic order) and by social security number (as second criteria, in increasing order).

*/

public enum University
{
    SU, UNSS, TU, NBU, Other
}

