namespace _02_simple_calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Stack<string> data = new Stack<string>();

            foreach (var symbol in input)
            {
                data.Push(symbol);
            }
            // Reverse the stack

            Stack<string> reversedData = new Stack<string>();
            while (data.Count > 0)
            {
                reversedData.Push(data.Pop());
            }

            double result = double.Parse(reversedData.Pop());

            while (reversedData.Count > 0)
            {
                if (reversedData.Peek() == "+")
                {
                    reversedData.Pop();
                    result += double.Parse(reversedData.Pop());
                }
                else if (reversedData.Peek() == "-")
                {
                    reversedData.Pop();
                    result -= double.Parse(reversedData.Pop());
                }
            }

            Console.WriteLine(result);
        }
    }
}
