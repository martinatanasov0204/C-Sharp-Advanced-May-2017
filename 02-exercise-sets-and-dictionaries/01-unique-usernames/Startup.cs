namespace _01_unique_usernames
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();

                uniqueUsernames.Add(username);
            }

            foreach (var uniqueUsername in uniqueUsernames)
            {
                Console.WriteLine(uniqueUsername);
            }
        }
    }
}
