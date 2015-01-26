using System;

namespace FibonacciNumbers

        //Problem 10. Fibonacci Numbers
        //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
        //(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
        //Note: You may need to learn how to use loops.

{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter number where to stop the sequance: ");
            int input = int.Parse (Console.ReadLine());

            int first = 1;
            int second = 1;
            int sum = 0;

            while (sum < input)

            {
               sum =  first + second;
               Console.Write("{0}, ", sum);

               first = second;
               second = sum; 
            }
        }
    }
}
