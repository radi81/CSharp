using System;

namespace HumanStudentAndWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.facultyNumber = facultyNumber;
        }

        public string FacultyNumber 
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "You have not entered a faculty number.");
                }

                if (string.Format(value).Length < 5
                    || string.Format(value).Length > 10)
                {
                    throw new ArgumentOutOfRangeException(
                        "Faculty number must be between 5 and 10 digits / letters.");
                }

                foreach (var charEntered in value)
                {
                    if (!char.IsLetterOrDigit(charEntered))
                    {
                        throw new FormatException(
                            "Faculty number must consists of digits / letters.");
                    }
                }

                this.facultyNumber = FacultyNumber;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", facultyNumber, firstName, lastName);
        }
    }
}
