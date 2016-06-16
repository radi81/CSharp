using System;

namespace _3.CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string ProjectName { get; set; }
        DateTime ProjectStartDate { get; set; }
        string Details { get; set; }
        ProjectState state { get; set; }

        void CloseProject();
    }
}
