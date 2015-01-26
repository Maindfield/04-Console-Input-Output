using System;
using System.Threading;
using System.Globalization;


namespace SumOfThreeNumbers

    //Problem 1. Sum of 3 Numbers
    //Write a program that reads 3 real numbers from the console and prints their sum.


{
    class SumOfThreeNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter first number: ");
            double firstNumber =  double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("The sum of these three numbers is: {0}", (firstNumber + secondNumber + thirdNumber));
        }
    }
}
