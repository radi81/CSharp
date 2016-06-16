using System;
using System.Collections.Generic;

namespace _3.CompanyHierarchy.Interfaces
{
    public interface ISale
    {
        string ProductName { get; set; }
        DateTime date { get; set; }
        decimal Price { get; set; }
    }
}
