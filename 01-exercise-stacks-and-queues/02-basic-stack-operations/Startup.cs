namespace _02_basic_stack_operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            var commands = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var amountOfNumbers = commands[0];
            var amountOfNumbersToPop = commands[1];
            var elementToCheck = commands[2];

            var numbersInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            Stack<double> numbers = new Stack<double>();

            // Fill the stack

            for (int i = 0; i < amountOfNumbers; i++)
            {
                numbers.Push(numbersInput[i]);
            }

            // Pop the stack

            for (int i = 0; i < amountOfNumbersToPop; i++)
            {
                numbers.Pop();
            }

            // Print result

            if (numbers.Contains(elementToCheck))
            {
                Console.WriteLine("true");
            }

            else if (numbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
