using System;
using System.Collections.Generic;

namespace _3.CompanyHierarchy.Interfaces
{
    public interface ISalesEmployee 
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
        List<ISale> ListOfSales { get; set; }
    }
}
