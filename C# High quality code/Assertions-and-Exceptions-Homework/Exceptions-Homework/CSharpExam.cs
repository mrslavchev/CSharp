using System;

public class CSharpExam : Exam
{
    private const int MIN_SCORE = 0;
    private const int MAX_SCORE = 100;
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score 
    { 
        get { return this.score; }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Score can not be negative");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score < MIN_SCORE || this.Score > MAX_SCORE)
        {
            throw new ArgumentException("Score has invalid value {0}, must be between 0 and 100", 
                this.Score.ToString());
        }
        else
        {
            return new ExamResult(this.Score, MIN_SCORE, MAX_SCORE, "Exam results calculated by score.");
        }
    }
}