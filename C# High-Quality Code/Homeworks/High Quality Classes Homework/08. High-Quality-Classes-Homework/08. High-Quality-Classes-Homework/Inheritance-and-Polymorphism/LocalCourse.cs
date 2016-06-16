namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    public class LocalCourse : Course
    {
        public LocalCourse(string courseName)
            : base(courseName)
        {
            this.TeacherName = null;
            this.Students = new List<string>();
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
            this.Students = new List<string>();
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
