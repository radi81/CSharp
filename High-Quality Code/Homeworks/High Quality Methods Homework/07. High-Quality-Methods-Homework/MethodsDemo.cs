namespace Methods
{
    using System;

    public class MethodsDemo
    {
        static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.ConvertDigitToString(5));

            Console.WriteLine(Methods.FindLargestInteger(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintAsFormatedNumber(1.3, "f");
            Methods.PrintAsFormatedNumber(0.75, "%");
            Methods.PrintAsFormatedNumber(2.30, "r");

            bool areHorizontal, areVertical;
            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5));
            Methods.AreAlignedHorizontally(3, -1, 3, 2.5, out areHorizontal);
            Console.WriteLine("Horizontal? " + areHorizontal);
            Methods.AreAlignedVertically(3, -1, 3, 2.5, out areVertical);
            Console.WriteLine("Vertical? " + areVertical);

            Student firstStudent = new Student()
            {
                FirstName = "Peter",
                LastName = "Ivanov"
            };
            firstStudent.OtherInfo = "From Sofia, born at 17.03.1992";

            Student secondStudent = new Student()
            {
                FirstName = "Stella",
                LastName = "Markova"
            };
            secondStudent.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                firstStudent.FirstName,
                secondStudent.FirstName,
                firstStudent.IsOlderThan(secondStudent));
        }
    }
}
