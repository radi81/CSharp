using System;

class FormatingNumbers
{
    static void Main()
    {
        Console.Write("Enter an integer a (0<=a<=500): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter a floating-point b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a floating-point c: ");
        double c = double.Parse(Console.ReadLine());
        string a1 = Convert.ToString(a, 2);
        int a2 = int.Parse(a1);

        Console.Write("|{0,-10:X}|{1:0000000000}", a, a2);
        Console.WriteLine("|{0,10:0.00}|{1,-10:0.000}", b, c);
    }
}

