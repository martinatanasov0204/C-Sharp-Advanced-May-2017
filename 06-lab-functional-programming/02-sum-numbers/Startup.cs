namespace _02_sum_numbers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			List<int> input = Console.ReadLine()
				.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			Console.WriteLine(input.Count);
			Console.WriteLine(input.Sum());
		}
	}
}
