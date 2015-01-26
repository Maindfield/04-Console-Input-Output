using System;

namespace NumbersInInterval

    //Problem 11.* Numbers in Interval Dividable by Given Number
    //Write a program that reads two positive integer numbers and prints how many numbers p exist between
    //them such that the reminder of the division by 5 is 0.

{
    class NumbersInInterval
    {
        static void Main()
        {
            Console.Write("Enter the start number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the end number: ");
            int b = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The count of \"p\" is: {0}", count);
        }
    }
}
