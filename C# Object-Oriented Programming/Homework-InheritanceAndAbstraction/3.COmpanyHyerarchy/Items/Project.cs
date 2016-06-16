using System;
using _3.CompanyHierarchy.Interfaces;

namespace _3.CompanyHierarchy.Items
{

    class Project : IProject
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private ProjectState state;

        internal Project(string projectName, DateTime projectStartDate,
            string details, ProjectState state)
        {
            this.projectName = projectName;
            this.projectStartDate = projectStartDate;
            this.details = details;
            this.state = state;      
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate
        {
            get
            {
                return this.projectStartDate;
            }
            set
            {
                this.projectStartDate = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }

        public ProjectState State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        ProjectState IProject.state
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }

        public override string ToString()
        {
            return "Project: " + this.ProjectName + "\n" + "Start date: "
                + this.ProjectStartDate + "\n" + "Status: " + this.State;
        }
    }
}
