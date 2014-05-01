using System;

public class SimpleMathExam : Exam
{
    private const int MIN_GRADE = 2;
    private const int MAX_GRADE = 6;
    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved 
    {
        get { return this.problemsSolved; }
        private set
        {
            if (value < 0 || value > 2)
            {
                throw new ArgumentException("Invalid number of porblem solved - {0}", value.ToString());
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        int currentGrade = 0;
        string currentComment = string.Empty;
        if (this.ProblemsSolved == 0)
        {
            currentGrade = 2;
            currentComment = "Bad result: nothing done.";
        }
        else if (this.ProblemsSolved == 1)
        {
            currentGrade = 4;
            currentComment = "Average result: 1 task done.";
        }
        else if (this.ProblemsSolved == 2)
        {
            currentGrade = 4;
            currentComment = "Excellent result: 2 tasks done.";
        }
        else
        {
            throw new ArgumentException("Invalid count of problems solved {0}", ProblemsSolved.ToString());
        }

        return new ExamResult(currentGrade, MIN_GRADE, MAX_GRADE, currentComment);
    }
}
