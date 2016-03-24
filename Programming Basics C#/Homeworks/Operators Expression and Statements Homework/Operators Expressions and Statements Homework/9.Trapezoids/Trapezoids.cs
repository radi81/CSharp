using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("This program calculates trapezoid's area " +
                "by given sides a and b and height h.");
            double a = 0;
            double b = 0;
            double h = 0;
            bool parseSuccsess_a = false;
            bool parseSuccsess_b = false;
            bool parseSuccsess_h = false;
            
            while ((parseSuccsess_a == false)||(a <= 0))
            {
                Console.Write("Side a = ");
                parseSuccsess_a = double.TryParse(Console.ReadLine(), out a);
                if ((parseSuccsess_a == false)||(a<= 0))
                {
                    Console.WriteLine("Invalid input. Enter a possitive number.");
                }
            }
            while ((parseSuccsess_b == false)||(b <= 0))
            {
                Console.Write("Side b = ");
                parseSuccsess_b = double.TryParse(Console.ReadLine(), out b);
                if ((parseSuccsess_b == false) || (b <= 0))
                {
                    Console.WriteLine("Invalid input. Enter a possitive number.");
                }
            }
            while ((parseSuccsess_h == false)||(h <= 0))
            {
                Console.Write("Height h = ");
                parseSuccsess_h = double.TryParse(Console.ReadLine(), out h);
                if ((parseSuccsess_h == false) || (h <= 0))
                {
                    Console.WriteLine("Invalid input. Enter a possitive number.");
                }
            }

            double area = (a + b) * h / 2;
            Console.WriteLine("The area A = {0}", area);
        }
    }

