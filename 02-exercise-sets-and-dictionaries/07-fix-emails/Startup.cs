namespace _07_fix_emails
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            string line = Console.ReadLine();
            Dictionary<string, string> people = new Dictionary<string, string>();

            string personName = string.Empty;
            int counter = 1;

            while (line != "stop")
            {
                if (counter % 2 == 0)
                {
                    string endOfEmail = line.Substring(line.Length - 2, 2);

                    if (endOfEmail != "us" && endOfEmail != "uk")
                    {
                        people.Add(personName, line);
                    }
                }
                else
                {
                    personName = line;
                }

                line = Console.ReadLine();
                counter++;
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
