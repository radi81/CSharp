using System;
using System.Collections.Generic;

namespace _3.CompanyHierarchy.Interfaces
{
    public interface IDeveloper 
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
        List<IProject> ListOfProjects { get; set; }
    }
}
