namespace _14_dragon_army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<int>>> dictionary = new Dictionary<string, Dictionary<string, List<int>>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var type = line[0];
                var name = line[1];
                int damage;
                int health;
                int armor;

                damage = int.TryParse(line[2], out damage) ? int.Parse(line[2]) : 45;
                health = int.TryParse(line[3], out health) ? int.Parse(line[3]) : 250;
                armor = int.TryParse(line[4], out armor) ? int.Parse(line[4]) : 10;

                if (dictionary.ContainsKey(type))
                {
                    if (dictionary[type].ContainsKey(name))
                    {
                        dictionary[type][name].Clear();

                        dictionary[type][name].Add(damage);
                        dictionary[type][name].Add(health);
                        dictionary[type][name].Add(armor);
                    }
                    else
                    {
                        dictionary[type].Add(name, new List<int>());
                        dictionary[type][name].Add(damage);
                        dictionary[type][name].Add(health);
                        dictionary[type][name].Add(armor);
                    }
                }
                else
                {
                    dictionary.Add(type, new Dictionary<string, List<int>>());
                    dictionary[type].Add(name, new List<int>());
                    dictionary[type][name].Add(damage);
                    dictionary[type][name].Add(health);
                    dictionary[type][name].Add(armor);

                }
            }

            Dictionary<string, List<double>> heroesWithAverageStats = new Dictionary<string, List<double>>();

            foreach (var type in dictionary)
            {
                heroesWithAverageStats.Add(type.Key, new List<double>());

                double damage = 0;
                double armor = 0;
                double health = 0;

                foreach (var name in type.Value)
                {
                    damage += name.Value[0];
                    health += name.Value[1];
                    armor += name.Value[2];
                }

                double avgDamage = damage / type.Value.Count;
                double avgHealth = health / type.Value.Count;
                double avgArmor = armor / type.Value.Count;

                heroesWithAverageStats[type.Key].Add(avgDamage);
                heroesWithAverageStats[type.Key].Add(avgHealth);
                heroesWithAverageStats[type.Key].Add(avgArmor);
            }

            foreach (var heroAndStats in heroesWithAverageStats)
            {
                Console.WriteLine($"{heroAndStats.Key}::({heroAndStats.Value[0]:F2}/{heroAndStats.Value[1]:F2}/{heroAndStats.Value[2]:F2})");

                foreach (var dragon in dictionary[heroAndStats.Key].OrderByDescending(d => d.Value.Average()))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
