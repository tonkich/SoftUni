using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<Exam> exams;



    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        

        if (lastName == null)
        {
            throw new ArgumentException("First name can't be null!");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get
        {
            if (firstName == null)
            {
                throw new ArgumentException("First name can't be null!");
            }
            return this.firstName;
        }
        set { this.firstName = value; }
    }
    public string LastName
    {
        get
        {
            if (lastName == null)
            {
                throw new ArgumentException("Last name can't be null!");
            }
            return this.lastName;
        }
        set { this.lastName = value; }
    }

    public IList<Exam> Exams
    {
        get
        {
            if (exams.Equals(0))
            {
                throw new ArgumentNullException("List can't be empty!");
            }
            return this.exams;
        }
        set { this.exams = value; }
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("Exams can't be null!");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentNullException("Exams can't be zero!");
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
            // Cannot calculate average on missing exams
            throw new ArgumentNullException("Exams can't be null!");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentNullException("Exams can't be zero!");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
