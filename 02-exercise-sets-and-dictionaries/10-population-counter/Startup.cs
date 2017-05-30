namespace _10_population_counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            string line = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> dictionary = new Dictionary<string, Dictionary<string, long>>();

            while (line != "report")
            {
                var parts = line.Split('|');

                var city = parts[0];
                var country = parts[1];
                var population = int.Parse(parts[2]);

                if (dictionary.ContainsKey(country))
                {
                    if (!dictionary[country].ContainsKey(city))
                    {
                        dictionary[country].Add(city, population);
                    }
                }
                else
                {
                    dictionary.Add(country, new Dictionary<string, long>());
                    dictionary[country].Add(city, population);
                }

                line = Console.ReadLine();
            }

            Dictionary<string, long> countriesAndPopulation = new Dictionary<string, long>();

            foreach (var country in dictionary)
            {
                long totalPopulation = 0;

                foreach (var city in country.Value)
                {
                    totalPopulation += city.Value;
                }

                countriesAndPopulation.Add(country.Key, totalPopulation);
            }

            foreach (var countryAndPopulation in countriesAndPopulation.OrderByDescending(cp => cp.Value))
            {
                Console.WriteLine($"{countryAndPopulation.Key} (total population: {countryAndPopulation.Value})");
                foreach (var city in dictionary[countryAndPopulation.Key].OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
