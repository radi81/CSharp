namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;

    public class ExceptionsDemo
    {
        static void Main()
        {
            var substr = Exceptions.ExtractSubsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Exceptions.ExtractSubsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Exceptions.ExtractSubsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Exceptions.ExtractSubsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(Exceptions.ExtractEnding("I love C#", 2));
            Console.WriteLine(Exceptions.ExtractEnding("Nakov", 4));
            Console.WriteLine(Exceptions.ExtractEnding("beer", 4));
            Console.WriteLine(Exceptions.ExtractEnding("Hi", 100));

            try
            {
                Exceptions.CheckPrime(23);
                Console.WriteLine("23 is prime.");
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("23 is not prime");
            }

            try
            {
                Exceptions.CheckPrime(33);
                Console.WriteLine("33 is prime.");
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("33 is not prime");
            }

            List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
