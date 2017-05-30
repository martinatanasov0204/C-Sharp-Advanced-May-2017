namespace _05_phonebook
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            string line = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (line != "search")
            {
                var person = line.Split('-');

                if (phonebook.ContainsKey(person[0]))
                {
                    phonebook[person[0]] = person[1];
                }
                else
                {
                    phonebook.Add(person[0], person[1]);
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (line != "stop")
            {
                if (phonebook.ContainsKey(line))
                {
                    Console.WriteLine($"{line} -> {phonebook[line]}");
                }
                else
                {
                    Console.WriteLine($"Contact {line} does not exist.");
                }

                line = Console.ReadLine();
            }
        }
    }
}
