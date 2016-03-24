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
            return this.grade;
        }

        private set
        {
            this.ValidateEnteredGrade(value);

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            this.ValidateEnteredGrade(value);

            this.minGrade = value;
        }
    }
    
    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        private set
        {
            this.ValidateEnteredGrade(value);

            if (this.maxGrade <= this.minGrade)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(this.maxGrade),
                    "Max grade must be greater than min grade.");
            }

            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            if (string.IsNullOrEmpty(this.comments))
            {
                throw new ArgumentNullException(
                    nameof(this.comments),
                    "No comments are entered.");
            }

            this.comments = value;
        }
    }

    private void ValidateEnteredGrade(int paramName)
    {
        if (string.IsNullOrEmpty(paramName.ToString()))
        {
            throw new ArgumentNullException(
                nameof(paramName),
                $"{ paramName } cannot be null or empty.");
        }

        int integerScore;
        if (!int.TryParse(paramName.ToString(), out integerScore))
        {
            throw new FormatException(
               $"{ paramName } must be integer");
        }

        if (this.grade < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(paramName),
                $"{ paramName } cannot be negative");
        }
    }
}
