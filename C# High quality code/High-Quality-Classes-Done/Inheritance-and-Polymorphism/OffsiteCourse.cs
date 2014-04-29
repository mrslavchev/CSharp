using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        public OffsiteCourse(string name)
            :base(name)
        {
        }

        public OffsiteCourse(string name, string teacherName)
            : base(name, teacherName)
        { 
        }

        public OffsiteCourse(string name, string teacherName, IList<string> students)
            : base(name, teacherName, students)
        { 
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("OffsiteCourse { Name = ");
            output.Append(base.ToString());

            return output.ToString();
        }
    }
}
