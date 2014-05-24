using System;

public class Student
{
    private string name;
    private int uniqueId;

    public Student(string name, School school)
    {
        this.Name = name;
        this.UniqueId = this.GenerateUniqueId(school);
    }

    public string Name
    {
        get { return this.name; }
        private set 
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name can not be null or empty.");
            }

            this.name = value;
        }
    }

    public int UniqueId
    {
        get { return this.uniqueId; }
        private set 
        {
            if (value < 10000 || value > 99999)
            {
                throw new ArgumentException("Id can not be less than 10 000 and bidgger than 99 999.");
            }

            this.uniqueId = value;
        }
    }

    /// <summary>
    /// Adds a student to course's list.
    /// </summary>
    /// <param name="student">Takes student as it's first parameter.</param>
    /// <param name="course">Takes course as its second parameter.</param>
    public static void AddCourse(Student student, Course course)
    {
        if (course.StudentsList.Count == 29)
        {
            throw new ArgumentException("Course is full.");
        }
        else
        {
            course.StudentsList.Add(student);
        }
    }

    /// <summary>
    /// Removes a student from a course's list.
    /// </summary>
    /// <param name="student">Takes student as it's first parameter.</param>
    /// <param name="course">Takes course as its second parameter.</param>
    public static void LeaveCourse(Student student, Course course)
    {
        if (course.StudentsList.Contains(student))
        {
            course.StudentsList.Remove(student);
        }
        else
        {
            throw new ArgumentException("Student not in list.");
        }
    }
    /*The reason for this method is that instead of reading number and checking if 
     it's valid, it's way better to just automate it and auto-generate the Id behind scenes.
     This way, we ensure no Ids bigger than 99999 and smaller than 10000 are generated.*/
    /// <summary>
    /// Generates unique Id automatically, to prevent users from input invalid data.
    /// </summary>
    /// <param name="school">Takes school as single parameter.</param>
    /// <returns>Unique Id.</returns>
    private int GenerateUniqueId(School school)
    {
        if (school.UniqueIds.Count == 89999)
        {
            throw new ArgumentException("Maximum count of unique ids reached, please contact your local administrator.");
        }
        else
        {
            if (school.UniqueIds.Count == 0)
            {
                int initialId = 10000;
                school.UniqueIds.Add(initialId);
                return initialId;
            }
            else
            {
                int lastPostition = school.UniqueIds.Count - 1;
                int currentLastId = school.UniqueIds[lastPostition];
                currentLastId++;
                school.UniqueIds.Add(currentLastId);
                return currentLastId;
            }
        }
    }
}