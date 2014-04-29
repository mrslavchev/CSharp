using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course 
    {
        private string lab;

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

        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab 
        {
            get { return this.lab; }
            set 
            {
                if (lab == string.Empty)
                {
                    throw new ArgumentException("Lab can not be empty string.");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("Local course { Name = ");
            output.Append(base.ToString());
            output.AppendFormat("; Lab: {0}", this.Lab ?? string.Empty );

            return output.ToString();
        }
    }
}
