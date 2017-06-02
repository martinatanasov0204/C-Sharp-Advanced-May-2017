namespace _03_group_numbers
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            var numbers = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToList();

            Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();

            foreach (var number in numbers)
            {
                var reminder = Math.Abs(number % 3);

                if (dictionary.ContainsKey(reminder))
                {
                    dictionary[reminder].Add(number);
                }
                else
                {
                    dictionary.Add(reminder, new List<int>());
                    dictionary[reminder].Add(number);
                }
            }

            int[][] matrix = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                if (dictionary.ContainsKey(i))
                {
                    matrix[i] = new int[dictionary[i].Count];

                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] = dictionary[i][j];
                    }
                }
                else
                {
                    matrix[i] = new int[0];
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
