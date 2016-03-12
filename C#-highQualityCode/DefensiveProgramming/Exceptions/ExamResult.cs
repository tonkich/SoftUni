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
        get
        {
            if (grade <0)
            {
                throw new ArgumentOutOfRangeException("Grade can't be negative number!");
            }
            return this.grade;
        }
        set { this.grade = value; }
    }

    public int MinGrade
    {
        get
        {
            if (minGrade < 0)
            {
                throw new ArgumentOutOfRangeException("Minimum grade can't be negative number!");
            }
            return this.minGrade;
        }
        set { this.minGrade = value; }
    }

    public int MaxGrade
    {
        get
        {
            if (maxGrade < 0)
            {
                throw new ArgumentOutOfRangeException("Maximum grade can't be negative number!");
            }
            return this.maxGrade;
        }
        set { this.maxGrade = value; }
    }

    public string Comments
    {
        get
        {
            if (string.IsNullOrEmpty(comments))
            {
                throw new ArgumentNullException("Comments can't be null!");
            }
            return this.comments;
        }
        private set { this.comments = value; }
    }
}
