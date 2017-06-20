namespace _04_find_evens_or_odds
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			int[] numbers = Console.ReadLine()
				.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			string command = Console.ReadLine();

			int start = numbers[0];
			int end = numbers[1];

			List<int> allNumbers = new List<int>();

			for (int j = start; j <= end; j++)
			{
				allNumbers.Add(j);
			}

			Predicate<int> findOdd = n => { return n % 2 != 0; };
			Predicate<int> findEven = n => { return n % 2 == 0; };

			if (command == "odd")
			{
				allNumbers.FindAll(findOdd).ForEach(n => Console.Write(n + " "));
			}
			else
			{
				allNumbers.FindAll(findEven).ForEach(n => Console.Write(n + " "));
			}

			Console.WriteLine();
		}
	}
}
