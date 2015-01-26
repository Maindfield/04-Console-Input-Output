using System;
using System.Threading;
using System.Globalization;

namespace QuadraticEquation

    //Problem 6. Quadratic Equation
    //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves
    //it (prints its real roots).

{
    class QuadraticEquation
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter coefficient a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter coefficient b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter coefficient c: ");
            double c = double.Parse(Console.ReadLine());

            double d = ((b * b) - 4 * (a * c));

            if (d < 0)
            {
                Console.WriteLine("This Quadratic Equation dont have real roots.");
            }

            else if (d == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("This Equation has only one root: {0}", x);
            }

            else if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The roots of this equation are: X1 = {0}, X2 = {1}", x1, x2);
            }
        }
    }
}
