using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanStudentAndWorker
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            List<Student> listStudents = new List<Student>();
            
            Console.WriteLine("Enter 10 students in format faculty number, " + 
                "first name and last name, separated by an interval: ");

            string line = Console.ReadLine();
           
            while (true)
            {
                string[] arr = line.Split(' ');
                Student student = new Student(arr[1], arr[2], arr[0]);
                listStudents.Add(student);
                if (counter == 9)
                {
                    break;
                }
                counter++;
                line = Console.ReadLine();
            }
            Console.WriteLine();
           
            var sortedListStudents = 
                listStudents.OrderBy(student => student.FacultyNumber);

            foreach (var student in sortedListStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            List < Worker > listWorkers = new List<Worker>();

            Console.WriteLine("Enter 10 workers in format first name, last name" +
                "week salary and work hours per day, separated by an interval: ");

            line = Console.ReadLine();
            counter = 0;

            while (true)
            {
                string[] arr = line.Split(' ');
                int weekSalary = int.Parse(arr[2]);
                int workHoursPerDay = int.Parse(arr[3]);
                Worker worker = new Worker(arr[0], arr[1], weekSalary, workHoursPerDay);
                listWorkers.Add(worker);
                if (counter == 9)
                {
                    break;
                }
                counter++;
                line = Console.ReadLine();
            }
            Console.WriteLine();
            
            var sortedListWorkers = 
                listWorkers.OrderByDescending(worker => worker.CalculateMoneyPerHour());

            foreach (var worker in sortedListWorkers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            List<Human> listSorted = sortedListStudents.Cast<Human>()
                .Union(sortedListWorkers.Cast<Human>())
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName)
                .ToList();
        }
    }
}
