namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class OffsiteCourse : Course
    {
        private string town = null;
        private string lab = null;

        public OffsiteCourse(string courseName)
            : base(courseName)
        {
            this.town = null;
            this.TeacherName = null;
            this.Students = new List<string>();
        }

        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, null)
        {
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
        }

        public string Town { get; set; }

        public override string Lab
        {
            get
            {
                return base.Lab;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "Lab must be null for offsite course");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            string result = base.ToString()
                .Replace("Lab", "Town")
                .Replace($"<this.Lab>", $"this.Town");

            return result;
        }
    }
}
