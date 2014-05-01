﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<Exam> exams;

    public Student(string firstName, string lastName, IList<Exam> exams)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get { return this.firstName; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("First name can not be null or empty.");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Last name can not be null or empty.");
            }

            this.lastName = value;
        }
    }

    public IList<Exam> Exams
    {
        get { return this.exams; }
        private set
        {
            if (value == null)
            {
                this.exams = new List<Exam>();
            }

            this.exams = value;
        }
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams.Count == 0)
        {
            throw new ArgumentException("Exams count can not be 0.");
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            throw new ArgumentException("Exams can not be null.");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentException("Exams count can not be 0.");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = this.CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
