namespace _06_a_miner_task
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main()
        {
            string line = Console.ReadLine();
            Dictionary<string, int> mineStorage = new Dictionary<string, int>();

            int counter = 1;
            string resourceType = string.Empty;

            while (line != "stop")
            {
                if (counter % 2 == 0)
                {
                    if (mineStorage.ContainsKey(resourceType))
                    {
                        mineStorage[resourceType] += int.Parse(line);
                    }
                    else
                    {
                        mineStorage.Add(resourceType, int.Parse(line));
                    }
                }
                else
                {
                    resourceType = line;
                }

                line = Console.ReadLine();
                counter++;
            }

            foreach (var resource in mineStorage)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
