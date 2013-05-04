using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : OffsiteCourse 
    {
        /// <summary>
        /// The only difference in properties between two forms is the Lab
        /// </summary>
        public string Lab { get; set; }
        /// <summary>
        /// inherit all constructors from base
        /// </summary>
        public LocalCourse(string name)
            : base(name)
        {
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
        }

        public string GetStudentsAsString()
        {
            return base.ToString();
        }
        /// <summary>
        /// We only maka some modifications because of the Lab property, otherways we inherit from base class again.
        /// </summary>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(base.Name);
            if (base.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(base.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(base.GetStudentsAsString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
