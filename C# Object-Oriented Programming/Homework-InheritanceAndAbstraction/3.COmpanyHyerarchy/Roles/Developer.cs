using System;
using System.Collections.Generic;
using _3.CompanyHierarchy.Interfaces;

namespace _3.CompanyHierarchy.Roles
{
    class Developer : Employee, IDeveloper
    {
        internal Developer(int id, string firstName, string secondName,
            decimal salary, Department department, List<IProject> listOfProjects)
            : base(id, firstName, secondName, salary, department)
        {
            this.ListOfProjects = listOfProjects;
        }

        public List<IProject> ListOfProjects { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nWork: " + 
                string.Join("; ", this.ListOfProjects);
        }
    }
}
