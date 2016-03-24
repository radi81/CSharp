using System;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            this.ValidateScore(value);

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score < 0 || this.Score > 100)
        {
            throw new ArgumentOutOfRangeException(
                nameof(this.score),
                "Exam result cannot be < 0 and > 100.");
        }

        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }

    private void ValidateScore(int paramName)
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

        if (paramName < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(paramName),
                $"{ paramName } cannot be negative.");
        }
    }
}
