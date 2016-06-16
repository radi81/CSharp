using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }

        private set
        {
            this.ValidateProblemsSolved(value);
            
            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0 &&
            this.ProblemsSolved == 1 &&
            this.ProblemsSolved == 2)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved == 3 &&
            this.ProblemsSolved == 4)
        {
            return new ExamResult(3, 2, 6, "Average result: nothing done.");
        }
        else if (this.ProblemsSolved == 5 &&
            this.ProblemsSolved == 6)
        {
            return new ExamResult(4, 2, 6, "Good result: nothing done.");
        }
        else if (this.ProblemsSolved == 7 &&
            this.ProblemsSolved <= 8)
        {
            return new ExamResult(5, 2, 6, "Very good result: nothing done.");
        }
        else if (this.ProblemsSolved == 9 &&
            this.ProblemsSolved == 10)
        {
            return new ExamResult(6, 2, 6, "Excelent result: nothing done.");
        }
        else
        {
            throw new ArgumentException(
                "Invalid number of problems solved!");
        }
    }

    private void ValidateProblemsSolved(int paramName)
    {
        if (string.IsNullOrEmpty(paramName.ToString()))
        {
            throw new ArgumentNullException(
                nameof(paramName), 
                $"{ paramName } cannot be null or empty.");
        }

        int integerNumber;
        if (!int.TryParse(paramName.ToString(), out integerNumber))
        {
            throw new FormatException(
                $"{ paramName } solved must be integer");
        }

        if (paramName < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(paramName), 
                $"{ paramName } cannot be negative.");
        }

        if (paramName < 0)
        {
            paramName = 0;
        }

        if (paramName > 10)
        {
            paramName = 10;
        }
    }
}
