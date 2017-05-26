namespace _01_reverse_numbers_with_a_stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            Stack<double> stackNumbers = new Stack<double>();

            foreach (var number in numbers)
            {
                stackNumbers.Push(number);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(stackNumbers.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
