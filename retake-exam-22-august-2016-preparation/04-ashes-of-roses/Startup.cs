namespace _04_ashes_of_roses
{
	using System;
	using System.Text.RegularExpressions;
	using System.Collections.Generic;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			string line = Console.ReadLine();

			Dictionary<string, Dictionary<string, long>> dictionary = new Dictionary<string, Dictionary<string, long>>();

			Regex regex = new Regex("^Grow <([A-Z][a-z]+)> <([A-Za-z0-9]+)> ([0-9]+)$");

			while (line != "Icarus, Ignite!")
			{
				Match match = regex.Match(line);

				if (match.Success)
				{
					string regionName = match.Groups[1].Value;
					string colorName = match.Groups[2].Value;
					long roseAmount = long.Parse(match.Groups[3].Value);

					if (dictionary.ContainsKey(regionName))
					{
						if (dictionary[regionName].ContainsKey(colorName))
						{
							dictionary[regionName][colorName] += roseAmount;
						}
						else
						{
							dictionary[regionName].Add(colorName, roseAmount);
						}
					}
					else
					{
						dictionary.Add(regionName, new Dictionary<string, long>());
						dictionary[regionName].Add(colorName, roseAmount);
					}
				}


				line = Console.ReadLine();
			}

			foreach (var region in dictionary.OrderByDescending(e => e.Value.Values.Sum()).ThenBy(e => e.Key))
			{
				Console.WriteLine(region.Key);

				foreach (var color in region.Value.OrderBy(e => e.Value).ThenBy(e => e.Key))
				{
					Console.WriteLine($"*--{color.Key} | {color.Value}");
				}
			}
		}
	}
}
