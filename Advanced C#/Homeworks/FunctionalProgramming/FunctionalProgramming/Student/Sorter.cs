namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Sorter
    {
        public static void PrintMarksOfStudentsEnrolledIn2014(IList<Student> students)
        {
            var studentsEnrolledIn2014 = from student in students
                                         where student.FacultyNumber % 100 == 14
                                         select
                                             new
                                             {
                                                 FullName = student.FirstName + string.Empty + student.LastName,
                                                 Marks = student.Marks
                                             };

            foreach (var student in studentsEnrolledIn2014)
            {
                Console.WriteLine("{0} {1}", student.FullName, string.Join(" ", student.Marks));
            }
        }

        public static void PrintAllStudentsWithAtLeastOneExellentMark(IList<Student> students)
        {
            var studentsWithExcelentMark = from student in students
                                           where student.Marks.Contains(6)
                                           select
                                               new
                                               {
                                                   FullName = student.FirstName + string.Empty + student.LastName,
                                                   Marks = student.Marks
                                               };

            //var studentsWithExcelentMark =
            //    students.Where(s => s.Marks.Contains(6))
            //    .Select(s => 
            //    new
            //        {
            //            FullName = s.FirstName + string.Empty + s.LastName,
            //            Marks = s.Marks
            //        });

            foreach (var student in studentsWithExcelentMark)
            {
                Console.WriteLine("{0} {1}", student.FullName, string.Join(" ", student.Marks));
            }
        }

        public static void PrintStudentsByGivenPhoneCode(string[] searchedPhoneCodes, IList<Student> students)
        {
            for (int i = 0; i < searchedPhoneCodes.Length; i++)
            {
                var filteredStudentsByPhone = from student in students
                                              where student.Phone.StartsWith(searchedPhoneCodes[i])
                                              select student;

                foreach (var student in filteredStudentsByPhone)
                {
                    Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Phone);
                }
            }
        }

        public static void PrintStudentsByEmailDomain(IList<Student> students, string emailDomain)
        {
            var filteredStudentsByDomain = from student in students
                                           where student.Email.Contains(emailDomain)
                                           select
                                               new
                                               {
                                                   FirstName = student.FirstName,
                                                   LastName = student.LastName,
                                                   Email = student.Email
                                               };

            foreach (var student in filteredStudentsByDomain)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Email);
            }
        }

        public static void PrintSortedStudentsDescending(IList<Student> students)
        {
            //var sortedListNamesDescending = students
            //    .OrderByDescending(s => s.FirstName)
            //    .ThenByDescending(s => s.LastName);

            var sortedListNamesDescending = from student in students
                                            orderby student.FirstName descending, student.LastName descending
                                            select student;

            foreach (var name in sortedListNamesDescending)
            {
                Console.WriteLine("{0} {1}", name.FirstName, name.LastName);
            }
        }

        public static void PrintFullNamesOfStudentsInAgeRange(IList<Student> students, int minAgeLimit, int maxAgeLimit)
        {
            //var studentsInAgeRange = students
            //    .Where(s => s.Age >= minAgeLimit && s.Age <= maxAgeLimit)
            //    .Select(
            //        s => new
            //        {
            //            FirstName = s.FirstName,
            //            LastName = s.LastName,
            //            Age = s.Age
            //        }); 

            var studentsInAgeRange = from student in students
                                     where student.Age >= minAgeLimit && student.Age <= maxAgeLimit
                                     select student;

            foreach (var student in studentsInAgeRange)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }
        }

        public static void PrintStudentsByFirstAndLastName(IList<Student> students)
        {
            //var alphabeticalyOrderedStudentNames =
            //    students
            //    .Where(s => s.FirstName[0].CompareTo(s.LastName[0]) < 0)
            //    .Select(s => new
            //    {
            //        FirstName = s.FirstName,
            //        LastName = s.LastName
            //    })
            //    .ToList();

            var alphabeticalyOrderedStudentNames = from student in students
                                                   where student.FirstName[0].CompareTo(student.LastName[0]) < 0
                                                   select student;

            foreach (var name in alphabeticalyOrderedStudentNames)
            {
                Console.WriteLine("{0} {1}", name.FirstName, name.LastName);
            }
        }

        public static void PrintAllStudentFromGroup(IList<Student> students, int groupNumber)
        {
            var studentsFromGroup2 =
                students.Where(g => g.GroupNumber == groupNumber).OrderBy(s => s.FirstName).Select(s => s.FirstName);

            foreach (var student in studentsFromGroup2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
