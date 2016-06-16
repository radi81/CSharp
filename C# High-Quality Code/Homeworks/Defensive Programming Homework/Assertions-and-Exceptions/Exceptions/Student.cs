using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private string firstName;

    private string lastName;

    private IList<Exam> exams;

    public Student(
        string firstName,
        string lastName,
        IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            this.ValidateName(value);

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            this.ValidateName(value);

            this.lastName = value;
        }
    }

    public IList<Exam> Exams
    {
        get
        {
            return this.exams;
        }

        set
        {
            this.ValidateExams(value);

            this.exams = value;
        }
    }

    public IList<ExamResult> CheckExams()
    {
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
            throw new ArgumentNullException(
                nameof(this.exams),
                "Cannot calculate average on missing exams");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentNullException(
                nameof(this.exams),
                "Count of exams must be > 0");
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

    private void ValidateName(string paramName)
    {
        if (string.IsNullOrEmpty(paramName))
        {
            throw new ArgumentNullException(
                nameof(paramName),
                $"{ paramName } cannot be null or empty.");
        }

        if (string.IsNullOrWhiteSpace(paramName))
        {
            throw new ArgumentNullException(
                nameof(paramName),
                $"{ paramName } cannot be null or white space.");
        }

        if (paramName.Length < 2)
        {
            throw new ArgumentOutOfRangeException(
                nameof(paramName),
                $"{ paramName } must contain minimum 2 letters");
        }
    }

    private void ValidateExams(IList< Exam > paramName)
    {
        if (paramName == null)
        {
            throw new Exception("Exams cannot be null.");
        }

        if (paramName.Count == 0)
        {
            Console.WriteLine("The student has no exams!");
        }
    }
}
