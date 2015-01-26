using System;
using System.Threading;
using System.Globalization;

namespace FormatingNumbers

    //Problem 5. Formatting Numbers
    //Write a program that reads 3 numbers:
    //    integer a (0 <= a <= 500)
    //    floating-point b
    //    floating-point c
    //The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
    //    The number a should be printed in hexadecimal, left aligned
    //    Then the number a should be printed in binary form, padded with zeroes
    //    The number b should be printed with 2 digits after the decimal point, right aligned
    //    The number c should be printed with 3 digits after the decimal point, left aligned.

{
    class FormatingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

            Console.Write("Enter integer a: ");
            int a = int.Parse(Console.ReadLine());

            if (0 <= a && a <= 500)
            {
                Console.Write("Enter floating-point b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Enter floating-point c: ");
                double c = double.Parse(Console.ReadLine());
                string aBinnary = Convert.ToString(a, 2).PadLeft(10, '0');

                Console.WriteLine("|{0,-10:X}|{3}|{1,10:N2}|{2,-10:F3}|", a, b, c, aBinnary);
            }
                else 
                {
                    Console.WriteLine("Wrong input, please enter number between [0...500]");
                }
        }
    }
}
