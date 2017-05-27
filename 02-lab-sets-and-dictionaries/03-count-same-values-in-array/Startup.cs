namespace _03_count_same_values_in_array
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

            SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (dictionary.ContainsKey(number))
                {
                    dictionary[number]++;
                }
                else
                {
                    dictionary.Add(number, 1);
                }
            }

            foreach (var number in dictionary)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
