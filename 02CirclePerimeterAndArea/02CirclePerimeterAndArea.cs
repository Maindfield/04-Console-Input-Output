using System;
using System.Threading;
using System.Globalization;

namespace CirclePerimeterAndArea

    //Problem 3. Circle Perimeter and Area
    //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the 
    //decimal point.

{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter radius for the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double area = radius * Math.PI * radius;
            double perimeter = radius * 2 * Math.PI; 

            Console.WriteLine(" The area of this circle is: {0}\n The perimeter of this circle is: {1}",
                               Math.Round(area, 2), Math.Round(perimeter, 2));

         }
    }
}
