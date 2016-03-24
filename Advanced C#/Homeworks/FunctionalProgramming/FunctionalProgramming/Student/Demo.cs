namespace Student
{
    using System;
    using System.Collections.Generic;

    public class Demo
    {
        public static void Main(string[] args)
        {
            IList<Student> students = new List<Student>()
                                          {
                                              new Student(
                                                  "Ivan",
                                                  "Ivanov",
                                                  23,
                                                  123414,
                                                  "0878675432",
                                                  "i_ivanov@abv.bg",
                                                  new List<int> { 3, 5, 6 },
                                                  2),
                                              new Student(
                                                  "Stefan",
                                                  "Tanev",
                                                  32,
                                                  176556,
                                                  "0882654987",
                                                  "s_stefanov@hotmail.com",
                                                  new List<int> { 2, 3, 4, 6 },
                                                  1),
                                              new Student(
                                                  "Maria",
                                                  "Vasileva",
                                                  33,
                                                  120914,
                                                  "+3592095623",
                                                  "m_vasileva@abv.bg",
                                                  new List<int> { 5, 5, 4, 6 },
                                                  2),
                                              new Student(
                                                  "Ivailo",
                                                  "Atanasov",
                                                  35,
                                                  123987,
                                                  "0877653400",
                                                  "i_atanasov@gmail.com",
                                                  new List<int> { 2, 2, 4, 5, 5 },
                                                  2),
                                              new Student(
                                                  "Ani",
                                                  "Nikolova",
                                                  23,
                                                  190572,
                                                  "023652318",
                                                  "a_nikolova@abv.bg",
                                                  new List<int> { 3, 5, 6 },
                                                  1)
                                          };

            // Print all students from group number 2
            int groupNumber = 2;
            Sorter.PrintAllStudentFromGroup(students, groupNumber);

            Console.WriteLine();

            // Print all students whose first name is before 
            // their last name alphabetically. 
            Sorter.PrintStudentsByFirstAndLastName(students);

            Console.WriteLine();

            // Finds the first name and last name of all 
            // students with age between 18 and 24
            int minAgeLimit = 18;
            int maxAgeLimit = 24;
            Sorter.PrintFullNamesOfStudentsInAgeRange(
                students,
                minAgeLimit,
                maxAgeLimit);

            Console.WriteLine();

            // Sort the students by first name and last name 
            // in descending order
            Sorter.PrintSortedStudentsDescending(students);

            Console.WriteLine();

            // Print all students that have email @abv.bg.
            string emailDomain = "@abv.bg";
            Sorter.PrintStudentsByEmailDomain(students, emailDomain);

            Console.WriteLine();

            // Print all students with phones in Sofia 
            // (starting with 02 / +3592 / +359 2). 
            string[] searchedPhoneCodes = { "02", "+3592", "+359 2" };
            Sorter.PrintStudentsByGivenPhoneCode(searchedPhoneCodes, students);
            
            Console.WriteLine();

            // Print all students that have at least one mark Excellent (6). 
            Sorter.PrintAllStudentsWithAtLeastOneExellentMark(students);

            Console.WriteLine();

            //// Write a similar program to the previous one to 
            //// extract the students with exactly two marks "2". 
            // var weakStudents = students
            //    .Where(s => s.Marks.Count(m => (m == 2).Count == 2))
            //    .Select(s => new
            //    {
            //        FullName = s.FirstName + string.Empty + s.LastName,
            //        Marks = s.Marks
            //    });

            // foreach (var student in weakStudents)
            // {
            //    Console.WriteLine(
            //        "{0} {1}",
            //        student.FullName,
            //        student.Marks);
            // }

            Console.WriteLine();

            // Extract and print the Marks of the students that enrolled in 2014
            // (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).
            Sorter.PrintMarksOfStudentsEnrolledIn2014(students);
        }
    }
}
