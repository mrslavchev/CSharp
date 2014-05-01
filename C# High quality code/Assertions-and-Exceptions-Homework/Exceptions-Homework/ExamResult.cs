using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade 
    {
        get { return this.grade; }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Grade can not be negative");
            }

            this.grade = value;
        }
    }
    
    public int MinGrade
    {
        get { return this.minGrade; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Minimum grade can not be negative");
            }

            this.minGrade = value;
        }
    }
    
    public int MaxGrade
    {
        get { return this.maxGrade; }
        set
        {
            if (value <= this.MinGrade)
            {
                throw new ArgumentException("Maximum grade can not be lower than or equal to minimum grade");
            }

            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get { return this.comments; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Comment can not be null or empty.");
            }

            this.comments = value;
        }
    }
}
