using System;

    class PointInCircleOutRectangle
    {
        static void Main()
        {
            Console.WriteLine("This program checks for givven point (x, y) " + 
            "if it is within the circle K({1, 1}, 1.5) and out of the rectangle " + 
            "R(top = 1, left = -1, width = 6, height = 2)");
            double x = 0;
            double y = 0;
            bool parseSuccsess_x = false;
            bool parseSuccsess_y = false;
            while (parseSuccsess_x == false)
            {
                Console.Write("x = ");
                parseSuccsess_x = double.TryParse(Console.ReadLine(), out x);
                if (parseSuccsess_x == false)
                {
                    Console.WriteLine("Invalid input. Enter possitive number");
                    parseSuccsess_x = false;
                }
            }
            while (parseSuccsess_y == false)
            {
                Console.Write("y = ");
                parseSuccsess_y = double.TryParse(Console.ReadLine(), out y);
                if (parseSuccsess_y == false)
                {
                    Console.WriteLine("Invalid input. Enter possitive number.");
                    parseSuccsess_y = double.TryParse(Console.ReadLine(), out y);
                    parseSuccsess_y = false;
                }
            }

            // (x - x1)^2 + (y - y1)^2 <= R^2; X1 = 1; X2 = 1
            if (((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5) &&
                (((y > 1) || (y < -1)) || ((x < -1) || (x > 5))) == true)
            {
                Console.WriteLine("Inside K & outside of R? yes");
            }
            else 
            {
                Console.WriteLine("Inside K & outside of R? no");
            }
        }   
    }


