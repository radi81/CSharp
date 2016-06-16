namespace Methods
{
    using System;

    public class Student
    {
        private string otherInfo;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            } 
             
            set
            {
                ValidateOtherInfo(value); 
                this.otherInfo = value;
            }
        }

        public bool IsOlderThan(Student secondStudent)
        {
            ValidateOtherInfo(secondStudent.OtherInfo);
            
            DateTime firstStudentBirthDate;
            try
            {
                firstStudentBirthDate = 
                    DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    "Birth date indicated in other info is not in valid format or is not entered.");
                throw;
            }
            
            DateTime secondStudentBirthDate;
            try
            {
                secondStudentBirthDate = 
                    DateTime.Parse(secondStudent.OtherInfo.Substring(secondStudent.OtherInfo.Length - 10));
            }
            catch (FormatException)
            {
                {
                    Console.WriteLine(
                        "Birth date indicated in other info is not in valid format or is not entered.");
                }

                throw;
            }

            bool firstIsOlderThanSecond = firstStudentBirthDate < secondStudentBirthDate;

            return firstIsOlderThanSecond;
        }

        private static void ValidateOtherInfo(string otherInfo)
        {
            if (string.IsNullOrEmpty(otherInfo))
            {
                throw new ArgumentNullException(
                    nameof(otherInfo),
                    "Other info cannot be null or empty.");
            }

            if (otherInfo.Length < 10)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(otherInfo),
                    "Birth date indicated in other info is not entered or is not in valid format.");
            }
        }
    }
}
