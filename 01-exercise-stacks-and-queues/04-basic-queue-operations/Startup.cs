namespace _04_basic_queue_operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            var commands = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var amountOfNumbers = commands[0];
            var amountOfNumbersToPop = commands[1];
            var elementToCheck = commands[2];

            var numbersInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            Queue<double> numbers = new Queue<double>();

            // Fill the stack

            for (int i = 0; i < amountOfNumbers; i++)
            {
                numbers.Enqueue(numbersInput[i]);
            }

            // Pop the stack

            for (int i = 0; i < amountOfNumbersToPop; i++)
            {
                numbers.Dequeue();
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
