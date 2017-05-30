namespace _09_user_logs
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            string line = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> dictionary = new SortedDictionary<string, Dictionary<string, int>>();

            while (line != "end")
            {
                var parts = line.Split(' ');

                var ip = parts[0].Substring(3, parts[0].Length - 3);
                var user = parts[2].Substring(5, parts[2].Length - 5);

                if (dictionary.ContainsKey(user))
                {
                    var ipDictionary = dictionary[user];

                    if (ipDictionary.ContainsKey(ip))
                    {
                        ipDictionary[ip]++;
                    }
                    else
                    {
                        ipDictionary.Add(ip, 1);
                    }
                }
                else
                {
                    dictionary.Add(user, new Dictionary<string, int>());
                    dictionary[user].Add(ip, 1);
                }

                line = Console.ReadLine();
            }

            foreach (var element in dictionary)
            {
                int counter = 0;

                Console.WriteLine($"{element.Key}: ");

                foreach (var piece in element.Value)
                {
                    if (counter == element.Value.Count - 1)
                    {
                        Console.WriteLine($"{piece.Key} => {piece.Value}.");

                    }
                    else
                    {
                        Console.Write($"{piece.Key} => {piece.Value}, ");

                    }

                    counter++;
                }
            }
        }
    }
}
