using System;
using System.Collections.Generic;

namespace HumanStudentAndWorker
{
    public abstract class Human 
    {
        protected string firstName;
        protected string lastName;

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; }
    }
}
