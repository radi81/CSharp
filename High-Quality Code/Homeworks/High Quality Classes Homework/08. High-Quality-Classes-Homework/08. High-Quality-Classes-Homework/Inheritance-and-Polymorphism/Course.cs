namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string courseName;
        private string teacherName;
        private IList<string> students;

        protected Course(string courseName)
        {
            this.CourseName = courseName;
            this.Students = new List<string>();
            this.Lab = null;
        }

        protected Course(string courseName, string teacherName)
            : this(courseName)
        {
            this.TeacherName = teacherName;   
        }

        protected Course(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                this.ValidateInputValue(value);
                this.courseName = value;
            }
        }

        public string TeacherName { get; set; }

        public IList<string> Students { get; set; }

        public virtual string Lab { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("LocalCourse { courseName = ");
            result.Append(this.CourseName);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");

            return result.ToString();
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }

            return "{ " + string.Join(", ", this.Students) + " }";
        }

        protected void ValidateInputValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    nameof(value),
                    "There is not an appropriate value in the field. Value cannot be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(
                    nameof(value),
                    "There is not an appropriate value in the field. Value cannot be null or white space.");
            }
        }
    }
}
