using System;
using System.Collections.Generic;
using _3.CompanyHierarchy.Roles;
using _3.CompanyHierarchy.Interfaces;
using _3.CompanyHierarchy.Items;

namespace _3.CompanyHierarchy
{
    class Program
    {
        static void Main()
        {
            Manager director = new Manager(456234, "Ivan", "Ivanov", 5000m, Department.Sales,
               new List<IEmployee>()
               {
                    new SalesEmployee(574856, "Katia", "Stoianova", 576834, Department.Sales, new List<ISale>()
                    {
                        new Sale("House1", new DateTime(2014, 7, 6), 100000m),
                        new Sale("House2", new DateTime(2014, 3, 1), 200600m)
                    }),
                    new Developer(586734, "Petio", "Petkov", 576834, Department.Sales, new List<IProject>()
                    {
                        new Project("Project1", new DateTime(2015,5,9), "Details...", ProjectState.Closed),
                        new Project("Project2", new DateTime(2015,6,7), "Details...", ProjectState.Open)
                    })
               });

            SalesEmployee salesPerson = new SalesEmployee(486756, "Tatiana", "Jeleva", 1500m, Department.Sales,
                new List<ISale>()
                {
                    new Sale("Land1", new DateTime(2013, 9,11), 25000m),
                    new Sale("Land2", new DateTime(2014, 10, 10), 75000m)
                });

            Developer developerPerson = new Developer(670234, "Malena", "Tosheva", 3000m, Department.Production,
                new List<IProject>()
                {
                    new Project("Project_564", new DateTime(2014,10,12), "Details...", ProjectState.Open),
                    new Project("Project_354", new DateTime(2011, 3,1),"Details...", ProjectState.Closed)
                });

            Person[] group = new Person[]
            {
                director, salesPerson, developerPerson
            };

            foreach (var member in group)
            {
                Console.WriteLine(member);
                Console.WriteLine();
            }
        }
    }
}
