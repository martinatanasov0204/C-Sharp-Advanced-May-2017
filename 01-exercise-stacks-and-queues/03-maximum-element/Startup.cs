namespace _03_maximum_element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<double> numbers = new Stack<double>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine();

                // Format => 1 x
                if (command.Length > 1)
                {
                    var numberToAdd = double.Parse(command.Substring(1, command.Length - 1));
                    
                    numbers.Push(numberToAdd);
                }
                // Format => 2
                else if (command == "2")
                {
                    numbers.Pop();
                }
                // Format => 3
                else
                {
                    Console.WriteLine(numbers.Max());
                }
            }
        }
    }
}
