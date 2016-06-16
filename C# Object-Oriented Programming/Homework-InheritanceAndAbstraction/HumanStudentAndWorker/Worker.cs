using System;

namespace HumanStudentAndWorker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string secondName,
            decimal weekSalary, int workHoursPerDay) 
            : base(firstName, secondName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentNullException(
                        "You have not entered a salary");
                }

                if (value < 0m)
                {
                    throw new ArgumentNullException(
                        "Salary must be a positive number.");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentNullException(
                        "You have not entered work hours per day.");
                }

                if (value < 0)
                {
                    throw new ArgumentNullException(
                        "Work hours per day must be a positive number.");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal CalculateMoneyPerHour()
        {
            decimal hourlyWage = this.WeekSalary / this.WorkHoursPerDay;
            return hourlyWage;
        }

        public override string ToString()
        {      
            return string.Format("{0:F2} {1} {2}",
                this.CalculateMoneyPerHour(), firstName, lastName);
        }
    }
}
