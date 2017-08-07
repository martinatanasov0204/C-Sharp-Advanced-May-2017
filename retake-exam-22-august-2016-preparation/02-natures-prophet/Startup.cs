
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15.LINQ_Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var stockSize = int.Parse(Console.ReadLine());
			var warehouse = new Dictionary<string, Dictionary<string, int>>();
			for (int i = 0; i < stockSize; i++)
			{
				var input = Console.ReadLine();
				var data = Regex.Matches(input, @"^\|(.*?)\s-\s(.*?)\s-\s(.*?)\|$");
				if (data.Count > 0)
				{
					var company = data[0].Groups[1].ToString();
					var amount = int.Parse(data[0].Groups[2].ToString());
					var product = data[0].Groups[3].ToString();

					if (!warehouse.ContainsKey(company))
					{
						warehouse.Add(company, new Dictionary<string, int>());
					}

					if (!warehouse[company].ContainsKey(product))
					{
						warehouse[company].Add(product, 0);
					}

					warehouse[company][product] += amount;
				}
			}
			foreach (var company in warehouse.OrderBy(x => x.Key))
			{
				Console.WriteLine($"{company.Key}: {string.Join(", ", company.Value.Select(x => $"{x.Key}-{x.Value}"))}");
			}
		}
	}
}