using System;
using System.Collections.Generic;

// Contains set of students
// Should be less than 30.
public class Course
{
    private List<Student> studentsList;

    public Course()
    {
        this.StudentsList = new List<Student>();
    }

    public List<Student> StudentsList
    {
        get { return this.studentsList; }
        private set
        {
            if (value == null)
            {
                throw new ArgumentException("List can not be null.");
            }

            this.studentsList = value;
        }
    }
}