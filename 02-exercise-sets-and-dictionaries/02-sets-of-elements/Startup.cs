namespace _02_sets_of_elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            var parameters = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int n = parameters[0];
            int m = parameters[1];

            HashSet<int> setM = new HashSet<int>();
            HashSet<int> setN = new HashSet<int>();

            for (int i = 0; i < n + m; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    setN.Add(num);
                }
                else
                {
                    setM.Add(num);
                }
            }

            foreach (var currN in setN)
            {
                if (setM.Contains(currN))
                {
                    Console.Write($"{currN} ");
                }
            }
            Console.WriteLine();
        }
    }
}
