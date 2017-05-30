namespace _03_periodic_table
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var element = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                element.ForEach(e => elements.Add(e));
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}