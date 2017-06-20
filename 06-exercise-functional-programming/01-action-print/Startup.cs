namespace _01_action_print
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Startup
	{
		static void Main()
		{
			List<string> input = Console.ReadLine()
				.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			Action<List<string>> names = givenName =>
			{
				givenName.ForEach(n => Console.WriteLine(n));
			};

			names(input);
		}
	}
}
