namespace _05_applied_arithmetics
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			List<int> numbers = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			string command = Console.ReadLine();

			Func<List<int>, List<int>> add = nums => nums.Select(n => n = n + 1).ToList();
			Func<List<int>, List<int>> subtract = nums => nums.Select(n => n = n - 1).ToList();
			Func<List<int>, List<int>> multiply = nums => nums.Select(n => n = n * 2).ToList();

			Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));

			while (command != "end")
			{
				if (command == "add")
				{
					numbers = add(numbers);
				}
				else if (command == "subtract")
				{
					numbers = subtract(numbers);
				}
				else if (command == "multiply")
				{
					numbers = multiply(numbers);
				}
				else
				{
					print(numbers);
				}

				command = Console.ReadLine();
			}
		}
	}
}
