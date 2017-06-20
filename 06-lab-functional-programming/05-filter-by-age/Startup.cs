namespace _05_filter_by_age
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			Dictionary<string, int> people = new Dictionary<string, int>();

			for (int i = 0; i < n; i++)
			{
				string[] param = Console.ReadLine()
					.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				string name = param[0];
				int age = int.Parse(param[1]);

				people.Add(name, age);
			}

			string condition = Console.ReadLine();
			int givenAge = int.Parse(Console.ReadLine());
			string[] format = Console.ReadLine().Split(' ').ToArray();

			if (format.Length == 2)
			{
				PrintNameAndAge(condition, givenAge, people);
			}
			else
			{
				if (format[0] == "name")
				{
					PrintName(condition, givenAge, people);
				}
				else
				{
					PrintAge(condition, givenAge, people);
				}
			}

		}

		public static void PrintNameAndAge(string cond, int age, Dictionary<string, int> people)
		{
			if (cond == "younger")
			{
				foreach (var person in people.Where(p => p.Value < age))
				{
					Console.WriteLine($"{person.Key} - {person.Value}");
				}
			}
			else
			{
				foreach (var person in people.Where(p => p.Value >= age))
				{
					Console.WriteLine($"{person.Key} - {person.Value}");
				}
			}
		}
		public static void PrintName(string cond, int age, Dictionary<string, int> people)
		{
			if (cond == "younger")
			{
				foreach (var person in people.Where(p => p.Value < age))
				{
					Console.WriteLine($"{person.Key}");
				}
			}
			else
			{
				foreach (var person in people.Where(p => p.Value >= age))
				{
					Console.WriteLine($"{person.Key}");
				}
			}
		}
		public static void PrintAge(string cond, int age, Dictionary<string, int> people)
		{
			if (cond == "younger")
			{
				foreach (var person in people.Where(p => p.Value < age))
				{
					Console.WriteLine($"{person.Value}");
				}
			}
			else
			{
				foreach (var person in people.Where(p => p.Value >= age))
				{
					Console.WriteLine($"{person.Value}");
				}
			}
		}
	}
}
