﻿using System;
using System.Text;


class Student : ICloneable, IComparable<Student>
{
    #region Properties
    public string FirstName {get; private set; } 
    public string SecondName { get; private set; }
    public string LastName { get; private set; }
    public int SSN { get; private set; }
    public string PermanentAddress { get; private set; }
    public string Email { get; private set; }
    public string MobilePhone { get; private set; }
    public byte? Course { get; private set; }
    public University UniversityName { get; protected set; }
    public Faculty FacultyName { get; protected set; }
    public Specialty SpecialtyName { get; protected set; }
    #endregion

    #region Constructors
    public Student(string firstName, string secondName, string lastName, int ssn, string permanentAddres,
        string eMail, string mobilePhone, byte? course, University universityName, Faculty facultyName, Specialty specialtyName)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.PermanentAddress = permanentAddres;
        this.Email = eMail;
        this.MobilePhone = mobilePhone;
        this.Course = course;
        this.UniversityName = universityName;
        this.FacultyName = facultyName;
        this.SpecialtyName = specialtyName;
    }

    public Student(string firstName, string secondName, string lastName, int ssn) :
        this(firstName, secondName, lastName, ssn, null,
       null, null, null, University.Other, Faculty.Other, Specialty.Other)
    { 
    }
    #endregion

    #region Operator and method overloads
    public static bool operator == (Student firstStudent, Student secondStudent)
    {
        return Student.Equals(firstStudent, secondStudent);
    }

    public static bool operator !=(Student firstStudent, Student secondStudent)
    {
        return !(Student.Equals(firstStudent, secondStudent));
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ SecondName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.AppendLine(this.FirstName);
        output.AppendLine(this.SecondName);
        output.AppendLine(this.LastName);
        output.AppendLine(this.SSN.ToString());
        return output.ToString();
    } 

    public Student Clone()
    {
        Student protoSudent = this;
        Student result = new Student(this.FirstName, this.SecondName, this.LastName, this.SSN, this.PermanentAddress,
            this.Email,this.MobilePhone,this.Course, this.UniversityName, this.FacultyName, this.SpecialtyName);
        return result;
    }

    Object ICloneable.Clone()
    {
        return this.Clone();
    }

    public int CompareTo(Student student)
    {
        if (this.FirstName != student.FirstName)
        {
            return (this.FirstName.CompareTo(student.FirstName));
        }

        if (this.SecondName != student.SecondName)
        {
            return (this.SecondName.CompareTo(student.SecondName));
        }

        if (this.LastName != student.LastName)
        {
            return(this.LastName.CompareTo(student.LastName));
        }

        if (this.SSN != student.SSN)
        {
            return(this.SSN.CompareTo(student.SSN));
        }

        return 0;
    }
    #endregion
}

