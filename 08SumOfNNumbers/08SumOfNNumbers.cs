using System;

namespace SumOfNNumbers

    //Problem 9. Sum of n Numbers
    //Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
    //Note: You may need to use a for-loop.

{
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers:");
            int input = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < input; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Summary:" + sum);
        }
    }
}
