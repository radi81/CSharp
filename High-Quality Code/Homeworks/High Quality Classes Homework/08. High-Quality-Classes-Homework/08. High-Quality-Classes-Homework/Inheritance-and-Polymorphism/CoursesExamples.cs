﻿namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class CoursesExamples
    {
        public static void Main()
        {
            Course localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.Students = new List<string>() { "Peter", "Maria" };
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            Course offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development",
                "Mario Peshev",
                new List<string>()
                    {
                        "Thomas", "Ani", "Steve"
                    });
            
            Console.WriteLine(offsiteCourse);
        }
    }
}
