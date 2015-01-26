using System;

namespace NumberComparer

    //Problem 4. Number Comparer
    //Write a program that gets two numbers from the console and prints the greater of them.
    //Try to implement this without if statements.

{
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The grater is :" + (firstNumber > secondNumber ? firstNumber : secondNumber));
        }
    }
}
