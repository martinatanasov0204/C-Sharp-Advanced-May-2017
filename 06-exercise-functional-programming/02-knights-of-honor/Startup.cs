namespace _02_knights_of_honor
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			List<string> input = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			Action<List<string>> outputNames = names =>
			{
				names.ForEach(n => Console.WriteLine($"Sir {n}"));
			};

			outputNames(input);
		}
	}
}
