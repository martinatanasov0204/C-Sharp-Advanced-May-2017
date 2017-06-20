namespace _03_custom_min_function
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			List<int> input = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			Func<List<int>, int> findSmallest = n => n.Min();

			Console.WriteLine(findSmallest(input));
		}
	}
}
