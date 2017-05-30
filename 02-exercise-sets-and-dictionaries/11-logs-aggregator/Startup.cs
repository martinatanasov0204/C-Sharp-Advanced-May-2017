namespace _11_logs_aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var ip = line[0];
                var user = line[1];
                var duration = int.Parse(line[2]);

                if (dictionary.ContainsKey(user))
                {
                    if (dictionary[user].ContainsKey(ip))
                    {
                        dictionary[user][ip] += duration;
                    }
                    else
                    {
                        dictionary[user].Add(ip, duration);
                    }
                }
                else
                {
                    dictionary.Add(user, new Dictionary<string, int>());
                    dictionary[user].Add(ip, duration);
                }
            }

            Dictionary<string, int> personDurations = new Dictionary<string, int>();

            foreach (var person in dictionary)
            {
                int totalDuration = 0;

                foreach (var duration in person.Value)
                {
                    totalDuration += duration.Value;
                }

                personDurations.Add(person.Key, totalDuration);
            }

            foreach (var personDuration in personDurations.OrderBy(p => p.Key))
            {
                Console.Write($"{personDuration.Key}: {personDuration.Value} [{string.Join(", ", dictionary[personDuration.Key].Keys.OrderBy(e => e))}]");

                Console.WriteLine();
            }
        }
    }
}
