using System;

public class SimpleMathExam : Exam
{

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved <= 0)
        {
            problemsSolved = 0;
        }
        if (problemsSolved > 10)
        {
            problemsSolved = 2;
        }
        else
        {
            problemsSolved = 1;
        }

        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved { get; private set; }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: you've solved nothing bloody basterd.");
        }
        else if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: you've done well but not excellent mate .");
        }
        else if (this.ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Maximum result: excellent work young chap.");
        }

        return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
    }
}
